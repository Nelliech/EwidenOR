using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.OleDb;
//using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace projekt_beta
{
    public partial class wyswietl_zabieg : Form
    {
        public wyswietl_zabieg()
        {
            InitializeComponent();
 
          
        }
        private void wyswietl_zabieg_Load(object sender, EventArgs e)
        {
            ArkuszDanych.DataSource = GetEmployeesList();
        }
        private DataTable GetEmployeesList()
        {
            DataTable dtEmployees = new DataTable();
            
            

            using (MySqlConnection con = new MySqlConnection(Program.path))
            {
                using (MySqlCommand cmd = new MySqlCommand("Select data_zabiegu,roslina,powierzchnia,nazwa,dawka,jednostka,przyczyna_stosowania,uwaga From Ewidencja " +
                    "Where id_uzytkownicy='" + Program.EmployeeName + "'", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtEmployees.Load(reader);
                }

            }
            dtEmployees.Columns[0].ColumnName = "Data Zabiegu";
            dtEmployees.Columns[1].ColumnName = "Nazwa Rośliny";
            dtEmployees.Columns[2].ColumnName = "Powierzchnia(ha)";
            dtEmployees.Columns[3].ColumnName = "Nazwa Środka";
            dtEmployees.Columns[4].ColumnName = "Dawka Środka";
            dtEmployees.Columns[5].ColumnName = "Jednostka";
            dtEmployees.Columns[6].ColumnName = "Przyczyna Stosowania";
            dtEmployees.Columns[7].ColumnName = "Uwagi";

            return dtEmployees;
        }
   

        private void button1_Click(object sender, EventArgs e)
        {

        }

     

        private void powrot_wyswietl_Click(object sender, EventArgs e)
        {
            Start st = new Start();
            st.Show();
            this.Hide();
        }


        /////////////////////////////////////////////////////////////////////////////////////////////Do PDF////////////////////////
        public void exportgridtopdf(DataGridView dgw, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text =  new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //add Header
            foreach (DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                 cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);


            }
            //add datarow
            foreach(DataGridViewRow row in dgw.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells )
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));

                }

            }
            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";
            if(savefiledialoge.ShowDialog()==DialogResult.OK)
            {
                using (FileStream stream= new FileStream(savefiledialoge.FileName,FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                }



            }


        }
        private void druk_Click(object sender, EventArgs e)
        {
            exportgridtopdf(ArkuszDanych, "Ewidencja");

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}

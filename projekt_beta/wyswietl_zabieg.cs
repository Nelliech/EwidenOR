using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_beta
{
    public partial class wyswietl_zabieg : Form
    {
        public wyswietl_zabieg()
        {
            InitializeComponent();
            
            string sciezka = null;
            sciezka = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EwidenOR1.accdb;";
            string format = Path.GetExtension(sciezka);
            ImportDanychAccess(sciezka, format, true);
            this.Show();
        }
        DataTable ImportTabeleAccess(string ścieżka, string format)
        {
            string sciezka = null;
            sciezka = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EwidenOR1.accdb;";

            string[] ograniczenia = new string[4]; ograniczenia[3] = "Table";
            OleDbConnection połączenie = new OleDbConnection(sciezka);
            połączenie.Open();

            DataTable dt = połączenie.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, ograniczenia);
            połączenie.Close();

            return dt;
        }

        void ImportDanychAccess(string ścieżka,  string format, bool wyświetl) 
        {
            string sciezka = null;       
            sciezka = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EwidenOR1.accdb;";

            OleDbConnection connect = new OleDbConnection(sciezka);
            connect.Open();
            DataTable dt = new DataTable();
            OleDbCommand komenda = new OleDbCommand("SELECT * FROM [Ewidencja]", connect);

            OleDbDataAdapter adapter = new OleDbDataAdapter(komenda);
            adapter.Fill(dt);
            if (wyświetl) ArkuszDanych.DataSource = dt;

           

            connect.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void wyswietl_zabieg_Load(object sender, EventArgs e)
        {

        }

        private void powrot_wyswietl_Click(object sender, EventArgs e)
        {
            Start st = new Start();
            st.Show();
            this.Hide();
        }
    }
}

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
using Microsoft.Office.Interop;
namespace projekt_beta
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
           
            
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void dodaj_ewidencje_Click(object sender, EventArgs e)
        {
            dodaj_zabieg dz = new dodaj_zabieg();
            dz.Show();
            this.Hide();
            
        }

        private void historia_ewidencji_Click(object sender, EventArgs e)
        {
            wyswietl_zabieg wz = new wyswietl_zabieg();
            wz.Show();
            this.Hide();
        }

        private void import_excel_Click(object sender, EventArgs e)
        {
            /*
            saveFileDialog1.ShowDialog();
            string path = saveFileDialog1.FileName;
            File.WriteAllText(path,)
            */
           

        }
       

    }
}

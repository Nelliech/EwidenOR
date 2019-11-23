using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace projekt_beta
{
    public partial class rejestracja : Form
    {
        public rejestracja()
        {
            InitializeComponent();
        }

        private void rejestracja_button_Click(object sender, EventArgs e)
        {
            string connString = "Server=sql7.freemysqlhosting.net;Database=sql7313253; Uid=sql7313253;Pwd=QtM4himqbd";
            MySqlConnection connection = new MySqlConnection(connString);
            string insertQuery = "SELECT id FROM uzytkownicy WHERE login= '" + login__text_rejestracja.Text +"';";



            MySqlConnection conDataBase = new MySqlConnection(connString);
            MySqlCommand command = new MySqlCommand(insertQuery, conDataBase);


            try
            {
                conDataBase.Open();
                Program.EmployeeName = command.ExecuteScalar().ToString();
                MessageBox.Show(Program.EmployeeName);
                if (!string.IsNullOrEmpty(Program.EmployeeName))
                {
                   

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}

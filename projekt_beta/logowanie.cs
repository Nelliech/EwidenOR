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
    public partial class logowanie : Form
    {
        public logowanie()
        {
            InitializeComponent();
            
            password_text.Text = "";
            password_text.PasswordChar = '*';         
            password_text.MaxLength = 8;
            wiadomosc_logowania.Hide();
        }

        private void zaloguj_button_Click(object sender, EventArgs e)
        {

            string connString = "Server=sql7.freemysqlhosting.net;Database=sql7313253; Uid=sql7313253;Pwd=QtM4himqbd";
            MySqlConnection connection = new MySqlConnection(connString);
            string insertQuery = "SELECT id FROM uzytkownicy WHERE BINARY login= '" + login_text.Text  + "' AND BINARY haslo= '" + password_text.Text + "';";
                

              
            MySqlConnection conDataBase = new MySqlConnection(connString);
            MySqlCommand command = new MySqlCommand(insertQuery, conDataBase);
            

            try
            {
                conDataBase.Open();
               
                //MessageBox.Show(Program.EmployeeName);
                if (command.ExecuteScalar() != null)
                {
                    connection.Close();

                    MessageBox.Show("Udało się zalogować");
                    Program.EmployeeName = command.ExecuteScalar().ToString(); // Przypisanie numeru id do zminnej EmployeeName pozwala określić kto jest zalogowany
                    Start st = new Start();
                    st.Show();
                    this.Hide();


                }
                else
                {

                    wiadomosc_logowania.Show();

                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void zalozkonto_button_Click(object sender, EventArgs e)
        {
            rejestracja st = new rejestracja();
            st.Show();
            this.Hide();

        }
    }
}

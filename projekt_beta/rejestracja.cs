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
            
            passre_text_rejestracja.PasswordChar = '*';
            pass_text_rejestracja.PasswordChar = '*';
            passre_text_rejestracja.MaxLength = 8;
            pass_text_rejestracja.MaxLength = 8;
            label_alert.Hide();
            label_alert_pass.Hide();
            label_alert_login.Hide();
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------
        private void rejestracja_button_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(imie_text_rejestracja.Text) ||//Jeśli pola sa puste pokaż komunikat
                string.IsNullOrEmpty(nazwisko_text_rejestracja.Text) ||
                string.IsNullOrEmpty(login_text_rejestracja.Text) ||
                string.IsNullOrEmpty(pass_text_rejestracja.Text))
            {
                label_alert.Show();

            }
            else
            {
                if ((pass_text_rejestracja.Text.Length >= 4)&&(pass_text_rejestracja.Text.Length<=8))
                {

                    if (passre_text_rejestracja.Text != pass_text_rejestracja.Text)//Jeśli pola password nie sa takie same pokaż komunikat
                    {

                        label_alert.Text = "Hasła nie są takie same";
                        label_alert.Show();

                    }
                    else
                    {
                        string connString = "Server=sql7.freemysqlhosting.net;Database=sql7313253; Uid=sql7313253;Pwd=QtM4himqbd";
                        MySqlConnection connection = new MySqlConnection(connString);
                        string insertQuery = "SELECT id FROM uzytkownicy WHERE BINARY login= '" + login_text_rejestracja.Text + "';";
                        MySqlConnection conDataBase = new MySqlConnection(connString);
                        MySqlCommand command = new MySqlCommand(insertQuery, conDataBase);

                        conDataBase.Open();


                        //MessageBox.Show(login_text_rejestracja.Text);
                        if (command.ExecuteScalar() != null)// Sprawdzenie czy jest w bazie danych wiersz z takim samym loginem
                        {
                            // Jest taki sam login

                            label_alert_login.Show();


                        }
                        else
                        {
                            //Nie ma jeszcze takiego loginu utworzonego
                            conDataBase.Close();
                            string connString2 = "Server=sql7.freemysqlhosting.net;Database=sql7313253; Uid=sql7313253;Pwd=QtM4himqbd";
                            MySqlConnection connection2 = new MySqlConnection(connString2);
                            string insertQuery2 = insertQuery = "INSERT INTO uzytkownicy (imie, nazwisko, login, haslo) VALUES ('" +
                                 imie_text_rejestracja.Text + "','" +
                                 nazwisko_text_rejestracja.Text + "','" +
                                 login_text_rejestracja.Text + "','" +
                                 pass_text_rejestracja.Text + "')";
                            MySqlConnection conDataBase2 = new MySqlConnection(connString2);
                            MySqlCommand command2 = new MySqlCommand(insertQuery2, conDataBase2);
                            MySqlDataReader myreader;

                            try
                            {
                                conDataBase2.Open();




                                myreader = command2.ExecuteReader();
                                while (myreader.Read())
                                {


                                }
                                MessageBox.Show("Konto zostało uwtorzone!");
                                logowanie st = new logowanie();
                                st.Show();
                                this.Hide();

                                conDataBase2.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }//Koniec (command.ExecuteScalar() != null)

                    }//Koniec (passre_text_rejestracja.Text != pass_text_rejestracja.Text)

                }
                else
                {
                    label_alert_pass.Show();

                }

            }// Koniec (string.IsNullOrEmpty(imie_text_rejestracja.Text) ||//Jeśli pola sa puste pokaż komunikat string.IsNullOrEmpty(nazwisko_text_rejestracja.Text) || .....
        }

        private void pass_text_rejestracja_Click(object sender, EventArgs e)
        {
            label_alert_pass.Hide();
        }

        private void login_text_rejestracja_Click(object sender, EventArgs e)
        {
            label_alert_login.Hide();
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------







    }
}

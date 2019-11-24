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
        }

        private void rejestracja_button_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(imie_text_rejestracja.Text)||//Jeśli pola sa puste pokaż komunikat
                string.IsNullOrEmpty(nazwisko_text_rejestracja.Text)||
                string.IsNullOrEmpty(login_text_rejestracja.Text)||
                string.IsNullOrEmpty(pass_text_rejestracja.Text))
            {
                label_alert.Show();

            }
            else
            {
                if(passre_text_rejestracja.Text!=pass_text_rejestracja.Text)//Jeśli pola są puste pokaż komunikat
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
                    
                   // Boolean reader = string.IsNullOrEmpty(command.ExecuteScalar().ToString());
                    MessageBox.Show(login_text_rejestracja.Text);
                    if (command.ExecuteScalar() != null)
                    {
                       ;

                        label_alert.Text = "Taki login już istnieje";
                        label_alert.Show();
                       


                    }
                    else
                    {
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
                            MessageBox.Show("Udało sie niby");
                            conDataBase2.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace projekt_beta
{
    public partial class edycja : Form
    {
        public edycja()
        {
            InitializeComponent();
        }
        public void ConnectMysql_update(string query)
        {
            MySqlConnection conDataBase = new MySqlConnection(Program.path);
            MySqlCommand command = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                }

                MessageBox.Show("Wiersz został zaktualizowany");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conDataBase.Close();





        }
        public void ConnectMysql_combobox(string query,params string[] wartosci)
        {
            
            MySqlConnection conDataBase = new MySqlConnection(Program.path);
            MySqlCommand command = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = command.ExecuteReader();
              
                while (myReader.Read())
                {

                    
                    DateTime sData_zabiegu = myReader.GetDateTime("data_zabiegu");
                    string sId= myReader.GetString("id");
                    string sRoslina = myReader.GetString("roslina");
                    string sPowierzchnia = myReader.GetString("powierzchnia");
                    string sNazwa = myReader.GetString("nazwa");
                    string sDawka = myReader.GetString("dawka");
                    string sJednostka = myReader.GetString("jednostka");
                    string sPryczyna_stosowania = myReader.GetString("przyczyna_stosowania");
                    string sUwaga = myReader.GetString("uwaga");
                
                    ewidencje_combobox.Items.Add(sId+"> "+sData_zabiegu.ToString("yyyy/MM/dd") + "||" +sRoslina+"||"+sPowierzchnia+"||"+sNazwa+"||"+sDawka+"||"+
                        sJednostka+"||"+sPryczyna_stosowania+"||"+sUwaga);

                }

                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conDataBase.Close();
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------
        public void Edycja(string query)
        {
           
            MySqlConnection conDataBase = new MySqlConnection(Program.path);
            MySqlCommand command = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {


                    DateTime sData_zabiegu = myReader.GetDateTime("data_zabiegu");
                    data_zabieg.Value = sData_zabiegu;
                    roslina_zabieg.Text= myReader.GetString("roslina");
                    powierzchnia_zabieg.Text= myReader.GetString("powierzchnia");
                    nazwa_zabieg.Text= myReader.GetString("nazwa");
                    dawka_zabieg.Text = myReader.GetString("dawka");
                    dawka_jednostki_zabieg.SelectedItem= myReader.GetString("jednostka");
                    przyczyna_zabieg.Text = myReader.GetString("przyczyna_stosowania");
                    uwagi_zabieg.Text=myReader.GetString("uwaga");
                   

                   
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conDataBase.Close();

        }

        private void edycja_Load(object sender, EventArgs e)
        {
            string insertQuery = "SELECT id, data_zabiegu, roslina, powierzchnia, nazwa, dawka, jednostka, przyczyna_stosowania, uwaga FROM Ewidencja WHERE id_uzytkownicy= '" + Program.EmployeeName + "';";
            ConnectMysql_combobox(insertQuery);
        }

        private void edycja_button_Click(object sender, EventArgs e)
        {
            string wiersze = this.ewidencje_combobox.GetItemText(this.ewidencje_combobox.SelectedItem);
            string index = wiersze.Substring(0, wiersze.LastIndexOf(">"));
            string insertQuery = "SELECT id, data_zabiegu, roslina, powierzchnia, nazwa, dawka, jednostka, przyczyna_stosowania, uwaga FROM Ewidencja WHERE id= '" + index + "';";
            Edycja(insertQuery);
        }

        private void zapisz_button_Click(object sender, EventArgs e)
        {
            string wiersze = this.ewidencje_combobox.GetItemText(this.ewidencje_combobox.SelectedItem);
            string index = wiersze.Substring(0, wiersze.LastIndexOf(">"));

            string insertQuery = "Update Ewidencja set data_zabiegu='" + data_zabieg.Value.ToString("yyyy-MM-dd") + "',roslina='" + roslina_zabieg.Text + "',powierzchnia='" + powierzchnia_zabieg.Text
                + "',nazwa='" + nazwa_zabieg.Text +"',dawka='" + dawka_zabieg.Text + "',jednostka='" + this.dawka_jednostki_zabieg.GetItemText(this.dawka_jednostki_zabieg.SelectedItem) +
                "',przyczyna_stosowania='" +przyczyna_zabieg.Text + "',uwaga='" + uwagi_zabieg.Text + "' Where id='" + index + "';";
            ConnectMysql_update(insertQuery);
        }

        private void powrot_button_Click(object sender, EventArgs e)
        {
            wyswietl_zabieg st = new wyswietl_zabieg();
            st.Show();
            this.Hide();
        }
    }
}

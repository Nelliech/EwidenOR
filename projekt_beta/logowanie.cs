using System;
using System.Windows.Forms;
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
        public void ConnectMysql(string query)
        {
            MySqlConnection connection = new MySqlConnection(Program.path);
            MySqlConnection conDataBase = new MySqlConnection(Program.path);
            MySqlCommand command = new MySqlCommand(query, conDataBase);
            conDataBase.Open();

            //MessageBox.Show(Program.EmployeeName);

            if (command.ExecuteScalar() != null)
            {
                connection.Close();
                Program.EmployeeName = command.ExecuteScalar().ToString(); // Przypisanie numeru id do zminnej EmployeeName pozwala określić kto jest zalogowany

                MessageBox.Show("Udało się zalogować");
                
                Start st = new Start();
                st.Show();
                this.Hide();


            }
            else
            {

                wiadomosc_logowania.Show();

            }

        }


        private void zaloguj_button_Click(object sender, EventArgs e)
        {
            string insertQuery = "SELECT id FROM uzytkownicy WHERE BINARY login= '" + login_text.Text  + "' AND BINARY haslo= '" + password_text.Text + "';";
            
            try
            {
               ConnectMysql(insertQuery);
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

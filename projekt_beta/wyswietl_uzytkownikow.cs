using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projekt_beta
{
    public partial class wyswietl_uzytkownikow : Form
    {
        public wyswietl_uzytkownikow()
        {
            InitializeComponent();
        }

        private void powrot_button_Click(object sender, EventArgs e)
        {
            Start st = new Start();
            st.Show();
            this.Hide();
        }

        private DataTable GetEmployeesList()
        {
            DataTable dtEmployees = new DataTable();



            using (MySqlConnection con = new MySqlConnection(Program.path))
            {
                using (MySqlCommand cmd = new MySqlCommand("Select * From uzytkownicy ;", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtEmployees.Load(reader);
                }

            }
            dtEmployees.Columns[0].ColumnName = "Id";
            dtEmployees.Columns[1].ColumnName = "Imię";
            dtEmployees.Columns[2].ColumnName = "Nazwisko";
            dtEmployees.Columns[3].ColumnName = "Login";
            dtEmployees.Columns[4].ColumnName = "Hasło";
           
            return dtEmployees;
        }

        private void wyswietl_uzytkownikow_Load(object sender, EventArgs e)
        {
            ArkuszDanych.DataSource = GetEmployeesList();
        }
    }
}

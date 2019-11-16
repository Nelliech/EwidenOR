using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;



namespace projekt_beta
{
    public partial class dodaj_zabieg : Form
    {

        
        public dodaj_zabieg()
        {
            InitializeComponent();
            dawka_jednostki_zabieg.SelectedIndex = 0;
            this.Show();
        }

        private void dodaj_zabieg_Load(object sender, EventArgs e)
        {

        }
       
        private void dodaj_Click(object sender, EventArgs e)
        {
          
           

            var data = data_zabieg.Value.Date;
             
            string roslina = roslina_zabieg.Text;
            string powierzchnia=powierzchnia_zabieg.Text; 
            double powierzchnia_double = Convert.ToDouble(powierzchnia);// Przechowuje z liczbą po przecinku


            string nazwa_zabiegu = nazwa_zabieg.Text;
            string dawka = dawka_zabieg.Text;
            double dawka_double = Convert.ToDouble(dawka);
            string jednostka = this.dawka_jednostki_zabieg.GetItemText(this.dawka_jednostki_zabieg.SelectedItem);
            string przyczyna = przyczyna_zabieg.Text;
            string uwagi = uwagi_zabieg.Text;
             
            string sciezka = null;
            OleDbConnection connect;
            sciezka = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EwidenOR1.accdb;";
            
            connect = new OleDbConnection(sciezka);
            
            /* próba łącznośći 
                                    try
                                    {
                                        cnn.Open();
                                        komunikat.Text="Connection Open ! ";
                                        cnn.Close();
                                    }
                                    catch (Exception ex)
                                    {
                                        komunikat.Text = "Can not open connection ! ";
                                    }
            */
            
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Ewidencja ([Data],[Roslina],[Powierzchnia],[Nazwa],[Dawka],[Jednostka],[Przyczyna_stosowania],[Uwagi]) values (?,?,?,?,?,?,?,?)";
            cmd.Parameters.AddWithValue("@Data", data);
            cmd.Parameters.AddWithValue("@Roslina", roslina);
            cmd.Parameters.AddWithValue("@Powierzchnia", powierzchnia_double);// problem z zmienno przecinkowmi  
            cmd.Parameters.AddWithValue("@Nazwa", nazwa_zabiegu);
            cmd.Parameters.AddWithValue("@Dawka", dawka_double);
            cmd.Parameters.AddWithValue("@Jednostka", jednostka);
            cmd.Parameters.AddWithValue("@Przyczyna_stosowania", przyczyna);
            cmd.Parameters.AddWithValue("@Uwagi", uwagi);


            cmd.Connection = connect;
            connect.Open();
            cmd.ExecuteNonQuery();

            komunikat_dodania m = new komunikat_dodania();
            
           
            m.Show();
            this.Hide();
        }


  

        private void powierzchnia_zabieg_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == ',') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void dawka_zabieg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == ',') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void powrot_zabieg_Click(object sender, EventArgs e)
        {
            Start st = new Start();
            st.Show();
            this.Hide();
        }
    }
}

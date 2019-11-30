using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace projekt_beta
{
    static class Program
    {
        public static string EmployeeName="1";
        public static string path = ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new logowanie());
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kontrola_Domowego_Budzetu.Forms;
using Kontrola_Domowego_Budzetu.Methods;

namespace Kontrola_Domowego_Budzetu
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogin formLogin = new FormLogin();
            Application.Run(formLogin);
            if(formLogin.IsLoggedIn() == true)
            {
                Application.Run(new Form1());
            }
            else
            {
                string message = "Błędny login lub hasło";
                string title = "Błąd logowania";
                DialogResult popUp;

                popUp = MessageBox.Show(message, title);
            }
            
        }
    }
}

using Kontrola_Domowego_Budzetu.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kontrola_Domowego_Budzetu.Forms;

namespace Kontrola_Domowego_Budzetu.Forms
{
    public partial class FormLogin : Form
    {
        bool isLoggedIn = false;
        Login tryToLog = new Login();
        public FormLogin()
        {
            InitializeComponent();
        }

        public bool IsLoggedIn()
        {
            return isLoggedIn;
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            isLoggedIn = tryToLog.isSuccessfulLogin(txtUserName, txtPassword);
            this.Close();
        }
        
    }
}

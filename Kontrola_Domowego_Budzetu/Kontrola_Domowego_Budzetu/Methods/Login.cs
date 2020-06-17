using Kontrola_Domowego_Budzetu.DataBase;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kontrola_Domowego_Budzetu.Methods;

namespace Kontrola_Domowego_Budzetu.Methods
{
    public class Login
    {
        
        
        public static List<string> LoginList()
        {
            List<string> Logins = new List<string>();
            using (var context = new BCEntities())
            {
                var LoginList = context.People.Select(x => x.Login).ToList();
                Logins = LoginList;
            }

            return Logins;
        }
        public static List<string> PasswordList()
        {
            List<String> Passwords = new List<string>();
            using (var context = new BCEntities())
            {
                var PassrowdList = context.People.Select(x => x.Password).ToList();
                Passwords = PassrowdList;
            }
            return Passwords;
        }
        public static List<string> NameList()
        {
            List<string> names;
            using (var context = new BCEntities())
            {
                var namesList = context.People.Select(x => x.Name).ToList();
                string test = namesList[1];
                names = namesList;
            }
            return names;
        }
        Form1 user = new Form1();
        string userLogin;
        public bool isSuccessfulLogin(TextBox login, TextBox password)
        {
            for (int i = 0; i < LoginList().Count; i++)
            {
                if (login.Text == LoginList()[i] && password.Text == PasswordList()[i])
                {
                    userLogin = NameList()[i].ToString();
                    user.GetName(userLogin);
                    return true;
                }
            }
            return false;
        }

    }
}

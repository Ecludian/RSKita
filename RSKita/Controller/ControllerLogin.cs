using RSKita.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RSKita.Controller
{
    class ControllerLogin
    {

        private Model.ModelPerson person;
        private LoginPage login;


        public ControllerLogin(LoginPage login)
        {
            this.login = login;
            person = new Model.ModelPerson();
        }

        public void LoginCheck()
        {
            person.Email_User = login.txtEmail.Text;
            person.Password_User = login.txtPassword.Password;
        
            bool result = person.LoginCheck(); 
            if (result)
            {
                
                View.HomePage home = new View.HomePage();
                home.Show();
                login.Close();
            }
            else
            {
                MessageBox.Show("Login Failed, check your email & password");
                login.txtEmail.Text = "";
                login.txtPassword.Password = "";
                login.txtEmail.Focus();
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RSKita.View
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        private Controller.ControllerLogin controllerLogin;
        public LoginPage()
        {
            InitializeComponent();
            MessageBox.Show(" RSKita ver Alpha 0.0.1 (Protoype) \n\n Copyright : \n Alvina Safitri Putri 19.61.0169 \n Charel Adhi Nugroho 19.61.0155 \n Frischa Prisilia L 19.61.0162 \n Labib Aqil Siraj 19.61.0165 \n\n\n 2021");
            txtEmail.Focus();


            Model.DBConnection test = new Model.DBConnection();
            test.CheckConnection();

            controllerLogin = new Controller.ControllerLogin(this);
       
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            controllerLogin.LoginCheck();
        }

        private void labelMasuk_Click(object sender, RoutedEventArgs e)
        {

        }

        private void labelDaftar_Click(object sender, RoutedEventArgs e)
        {
            View.RegisterPage signUp = new RegisterPage();
            signUp.Show();
            this.Close();
        }
    }
}

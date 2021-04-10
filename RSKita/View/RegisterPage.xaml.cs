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
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Window
    {
        Controller.RegisterController controller;

        private string proses;
        private bool hasil;
        public RegisterPage()
        {
            proses = "";
            InitializeComponent();
            controller = new Controller.RegisterController(this);
       
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            hasil = controller.insertUser();

            if (hasil == true)
            {
                MessageBox.Show("Register Successfull");
            }
            else
            {
                MessageBox.Show("Register Failed");
            }
        }

        private void labelMasuk_Click(object sender, RoutedEventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Close();
        }
    }
}

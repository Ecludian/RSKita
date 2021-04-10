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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RSKita.View
{
    /// <summary>
    /// Interaction logic for PaymentConfirmPage.xaml
    /// </summary>
    public partial class PaymentConfirmPage : Page
    {
        private Controller.cfrmController cfrmController;
        private HomePage homePage;

        public PaymentConfirmPage()
        {
            
            InitializeComponent();
            frame.Visibility = Visibility.Hidden;
            homePage = new HomePage();
            cfrmController = new Controller.cfrmController(this);
            cfrmController.showData();
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            HomePage newWindow = new HomePage();
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            homePage.Close();
        }
    }
}

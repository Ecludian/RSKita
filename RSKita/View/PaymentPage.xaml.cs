using RSKita.Data;
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
    /// Interaction logic for PaymentPage.xaml
    /// </summary>
    public partial class PaymentPage : Page
    {

        private Controller.PaymentController paymentController;
        public PaymentPage()
        {
          
            InitializeComponent();
            frame.Visibility = Visibility.Hidden;
            paymentController = new Controller.PaymentController(this);
            paymentController.pay();
        }

        private void btnConfirm_Click_1(object sender, RoutedEventArgs e)
        {
            paymentController.PushTotal();
            frame.Visibility = Visibility.Visible;
            frame.Content = new PaymentConfirmPage();
            frame.Navigate(new View.PaymentConfirmPage());
        }
    }
}

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
    /// Interaction logic for DoctorPage.xaml
    /// </summary>
    public partial class DoctorPage : Page
    {
        private Controller.DoctorController doctorController;
        private Controller.AppointmentController appointmentController;
        public DoctorPage()
        {
            InitializeComponent();
            frame.Visibility = Visibility.Hidden;
            doctorController = new Controller.DoctorController(this);
            appointmentController = new Controller.AppointmentController(this);
            doctorController.displayDoctor();
        }

        private void btnPayment_Click(object sender, RoutedEventArgs e)
        {
            appointmentController.getAptDate();
            frame.Visibility = Visibility.Visible;
            frame.Content = new PaymentPage();
            frame.Navigate(new View.PaymentPage());
        }
    }
}

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
    /// Interaction logic for PoliPage.xaml
    /// </summary>
    public partial class PoliPage : Page
    {
        private Controller.PoliController controller;
        int amount, amount2;
        public PoliPage()
        {
            InitializeComponent();
            frame.Visibility = Visibility.Hidden;
            controller = new Controller.PoliController(this);
            amount = 0;
            amount2 = 0;
            controller.start = amount;
            controller.st = amount2;
            controller.ShowHospital();
           // controller.getSchedule();
           // MessageBox.Show("DOKTER : " + HospitalInfo.docId + HospitalInfo.rsAddress + HospitalInfo.rsName + HospitalInfo.rsId);

        }

        private void label2_Copy16_Click(object sender, RoutedEventArgs e)
        {
            frame.Visibility = Visibility.Visible;
            frame.Content = new HospitalPage2();
            frame.Navigate(new View.HospitalPage2());
        }

        private void btngo1_Click(object sender, RoutedEventArgs e)
        {
            frame.Visibility = Visibility.Visible;
            frame.Content = new DoctorPage();
            frame.Navigate(new View.DoctorPage());
        }
    }
}

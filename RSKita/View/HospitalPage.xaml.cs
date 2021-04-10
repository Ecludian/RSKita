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
    /// Interaction logic for HospitalPage.xaml
    /// </summary>
    public partial class HospitalPage : Page
    {
        private Controller.HospitalController hController;

        public HospitalPage()
        {
            InitializeComponent();

            //hController = new Controller.HospitalController(this);
            hController.ShowHospital();
            frame.Visibility = Visibility.Hidden;


        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {

        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void MouseClick(object sender, MouseButtonEventArgs e)
        {
            //scroller.Visibility = Visibility.Hidden;
            frame.Visibility = Visibility.Visible;
            frame.Content = new PoliPage();
            frame.Navigate(new View.PoliPage());
            MessageBox.Show("test");
        }
    }
}

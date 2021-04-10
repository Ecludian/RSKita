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
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        private Controller.HomePageController homePageController;
        private Controller.ControllerLogin controller;
        public HomePage()
        {
            InitializeComponent();

            homePageController = new Controller.HomePageController(this);
            homePageController.displayUser();
            homePageController.displayticket();
            frame.Visibility = Visibility.Hidden;
        }


        private void btnHome_Click_1(object sender, RoutedEventArgs e)
        {
            frame.Visibility = Visibility.Hidden;
        }

        private void btnSearch_Click_1(object sender, RoutedEventArgs e)
        {
            frame.Visibility = Visibility.Visible;
            frame.Content = new HospitalPage2();
            frame.Navigate(new View.HospitalPage2());
        }

        private void btnHistory_Click_1(object sender, RoutedEventArgs e)
        {
            frame.Visibility = Visibility.Visible;
            frame.Content = new HistoryPage();
            frame.Navigate(new View.HistoryPage());
            
        }
        private void frame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            //ignore this, misclicked lol
        }

        private void btnNewAppt_Click(object sender, RoutedEventArgs e)
        {
            frame.Visibility = Visibility.Visible;
            frame.Content = new HospitalPage2();
            frame.Navigate(new View.HospitalPage2());
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

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
using System.Windows.Threading;

namespace RSKita.View
{
    /// <summary>
    /// Interaction logic for HospitalPage2.xaml
    /// </summary>
    public partial class HospitalPage2 : Page
    {
        private Controller.HospitalController controller;
        private Model.ModelHospital modelHospital;

        int amount;
        public HospitalPage2()
        {
            InitializeComponent();
            controller = new Controller.HospitalController(this);
            modelHospital = new Model.ModelHospital();
            amount = 0;
            controller.start = amount;
            controller.ShowHospital();
            frame.Visibility = Visibility.Hidden;
           
        }

        private void btngo1_Click(object sender, RoutedEventArgs e)
        {

            HospitalInfo.rsName = lblHospitalName1.Content.ToString();
            modelHospital.GetDoc();

           frame.Visibility = Visibility.Visible;
                frame.Content = new PoliPage();
                frame.Navigate(new View.PoliPage());
     

        }

        private void btngo2_Click(object sender, RoutedEventArgs e)
        {
            
            HospitalInfo.rsName = lblHospitalName2.Content.ToString();
            modelHospital.GetDoc();
          
                //MessageBox.Show("test \n" + HospitalInfo.rsName + "\n" + HospitalInfo.rsId);
                frame.Visibility = Visibility.Visible;
                frame.Content = new PoliPage();
                frame.Navigate(new View.PoliPage());
  

        }

        private void btngo3_Click(object sender, RoutedEventArgs e)
        {
            HospitalInfo.rsName = lblHospitalName3.Content.ToString();
            modelHospital.GetDoc();

               // MessageBox.Show("test \n" + HospitalInfo.rsName + "\n" + HospitalInfo.rsId);
                frame.Visibility = Visibility.Visible;
                frame.Content = new PoliPage();
                frame.Navigate(new View.PoliPage());
    
        }

        private void btngo4_Click(object sender, RoutedEventArgs e)
        {
            HospitalInfo.rsName = lblHospitalName4.Content.ToString();
            modelHospital.GetDoc();
         
                //MessageBox.Show("test \n" + HospitalInfo.rsName + "\n" + HospitalInfo.rsId);
                frame.Visibility = Visibility.Visible;
                frame.Content = new PoliPage();
                frame.Navigate(new View.PoliPage());
           
        }

    }
}

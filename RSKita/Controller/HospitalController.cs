using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace RSKita.Controller
{
    class HospitalController
    {
        private Model.ModelHospital hospital;
        private View.HospitalPage2 hospitalPage;
        public int start;

        public HospitalController(View.HospitalPage2 hospitalPage)
        {
            this.hospitalPage = hospitalPage;
            hospital = new Model.ModelHospital();

        }

        public void ShowHospital()
        {
            DataSet data = hospital.GetHospital();
            int count = data.Tables[0].Rows.Count;
           

            //show data
            //data 1
            if (start >= count)
            {
                Uri image1 = new Uri("/Image/Hospital.jpg", UriKind.Relative);
                hospitalPage.HospitalImage1.Source = new BitmapImage(image1);
                hospitalPage.lblHospitalName1.Content = "-";
                hospitalPage.lblHospitalAddres1.Content = "-";
            }
            else
            {
                Uri image1 = new Uri("/Image/" + data.Tables[0].Rows[start][4], UriKind.Relative);
                hospitalPage.HospitalImage1.Source = new BitmapImage(image1);
                hospitalPage.lblHospitalName1.Content = data.Tables[0].Rows[start][1];
                hospitalPage.lblHospitalAddres1.Content = data.Tables[0].Rows[start][2];
              
            }
            start++;

            //data 2
            if (start >= count)
            {
                Uri image2 = new Uri("/Image/Hospital.jpg", UriKind.Relative);
                hospitalPage.HospitalImage2.Source = new BitmapImage(image2);
                hospitalPage.lblHospitalName2.Content = "-";
                hospitalPage.lblHospitalAddres2.Content = "-";
            }
            else
            {
                Uri image2 = new Uri("/Image/" + data.Tables[0].Rows[start][4], UriKind.Relative);
                hospitalPage.HospitalImage2.Source = new BitmapImage(image2);
                hospitalPage.lblHospitalName2.Content = data.Tables[0].Rows[start][1];
                hospitalPage.lblHospitalAddres2.Content = data.Tables[0].Rows[start][2];
            
            }
            start++;
            
            //data 3
            if (start >= count)
            {
                Uri image3 = new Uri("/Image/Hospital.jpg", UriKind.Relative);
                hospitalPage.HospitalImage3.Source = new BitmapImage(image3);
                hospitalPage.lblHospitalName3.Content = "-";
                hospitalPage.lblHospitalAddres3.Content = "-";
            }
            else
            {
                Uri image3 = new Uri("/Image/" + data.Tables[0].Rows[start][4], UriKind.Relative);
                hospitalPage.HospitalImage3.Source = new BitmapImage(image3);
                hospitalPage.lblHospitalName3.Content = data.Tables[0].Rows[start][1];
                hospitalPage.lblHospitalAddres3.Content = data.Tables[0].Rows[start][2];
           
            }
            start++;


            //data 3
            if (start >= count)
            {
                Uri image4 = new Uri("/Image/Hospital.jpg", UriKind.Relative);
                hospitalPage.HospitalImage4.Source = new BitmapImage(image4);
                hospitalPage.lblHospitalName4.Content = "-";
                hospitalPage.lblHospitalAddres4.Content = "-";
            }
            else
            {
                Uri image3 = new Uri("/Image/" + data.Tables[0].Rows[start][4], UriKind.Relative);
                hospitalPage.HospitalImage4.Source = new BitmapImage(image3);
                hospitalPage.lblHospitalName4.Content = data.Tables[0].Rows[start][1];
                hospitalPage.lblHospitalAddres4.Content = data.Tables[0].Rows[start][2];
       
            }
            start++;

        }












        //BELOW CODE IS FOR CONVERTING DATASET INTO LIST
        /*
        public void ShowHospital()
        {
            DataSet data = hospital.GetHospital();

           // List<string> hospitalist = data.Tables[0].AsEnumerable().Select(r => r.Field<string>("Nama_rs")).ToList();

            foreach (var dt in data.Tables)
            {
                var hospitalist = data.Tables[0].AsEnumerable()
                    .Select(dr => new
                    {
                        IdHospital = dr.Field<string>("Id_rs"),
                        Name = dr.Field<string>("Nama_rs"),
                        Address = dr.Field<string>("Alamat_rs"),
                        Rating = dr.Field<decimal>("Rate_rs"),
                        IdDoc = dr.Field<string>("Id_doct")

                    }).ToList();

               //do something
                hospitalPage.ListHospital.ItemsSource = hospitalist;
            }
        }
        */
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace RSKita.Controller
{
    class PoliController
    {
        private Model.ModelPoli modelPoli;
        private View.PoliPage poliPage;
        public int start;
        public int st;
        public PoliController(View.PoliPage poliPage)
        {
            this.poliPage = poliPage;
            modelPoli = new Model.ModelPoli();
        }

        public void ShowHospital()
        {
            DataSet data = modelPoli.GetDoc();
            int count = data.Tables[0].Rows.Count;

            //show data
            //data 1
            if (start == count)
            {

                Uri image1 = new Uri("/Image/admin.jpg", UriKind.Relative);
                //poliPage.HospitalImage1.Source = new BitmapImage(image1);
                poliPage.lblDrName.Content = "-";
                poliPage.lblDrSpeicality.Content = "-";
                poliPage.lblRsAddres.Content = "-";
                poliPage.lblRsName.Content = "-";
            }
            else
            {
                Uri rs_Logo = new Uri("/Image/" + HospitalInfo.rsImage.ToString(),UriKind.Relative);
                poliPage.rslogo.Source = new BitmapImage(rs_Logo);
                Uri dr_portrait = new Uri("/Image/" + data.Tables[0].Rows[start][3],UriKind.Relative);
                poliPage.dr_image.Source = new BitmapImage(dr_portrait);
                poliPage.lblDrName.Content = data.Tables[0].Rows[start][1];
                poliPage.lblDrSpeicality.Content = ("Spesialis ") + data.Tables[0].Rows[start][2];
                poliPage.lblRsAddres.Content = HospitalInfo.rsAddress.ToString();
                poliPage.lblRsName.Content = HospitalInfo.rsName.ToString();
                poliPage.lblRsRate.Content = HospitalInfo.rsRate.ToString();
            }
            start++;

        }

    }
}

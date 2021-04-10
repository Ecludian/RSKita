using RSKita.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace RSKita.Controller
{
    class DoctorController
    {
        private DoctorPage doctorPage;

        public DoctorController(DoctorPage doctorPage)
        {
            this.doctorPage = doctorPage;
        }

        public void displayDoctor()
        {
            doctorPage.lblDrName.Content = DocInfo.docName;
            doctorPage.lblDrSpecialist.Content =("Spesialis ") + DocInfo.docSpecial;
            Uri drPortrait = new Uri("/Image/" + DocInfo.docImage.ToString(), UriKind.Relative);
            doctorPage.imageDr.Source = new BitmapImage(drPortrait);
        }
    }
}

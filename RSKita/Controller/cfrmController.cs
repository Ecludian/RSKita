using RSKita.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace RSKita.Controller
{
    class cfrmController
    {
        View.PaymentConfirmPage confirmPage;

        public cfrmController(View.PaymentConfirmPage confirmPage)
        {
            this.confirmPage = confirmPage;
        }

        public void showData()
        {
            confirmPage.lblDocName.Content = DocInfo.docName;
            confirmPage.lblDocSpecialist.Content = ("Spesialis ") + DocInfo.docSpecial;
            confirmPage.lbltgl.Content = Convert.ToDateTime(PaymenData.consultDate);
            confirmPage.lblTime.Content = PaymenData.consultTime;
            Uri drPortrait = new Uri("/Image/" + DocInfo.docImage.ToString(), UriKind.Relative);
            confirmPage.drimage.Source = new BitmapImage(drPortrait);
            confirmPage.lblQueueId.Content = ("AN-") + UserInfo.userId + HospitalInfo.rsId;
        }
    }
}

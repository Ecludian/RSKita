using RSKita.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace RSKita.Controller
{
    class PaymentController
    {
        private View.PaymentPage paymentPage;
        private Model.ModelPoli ModelPoli;
        private Model.ModelConfirmation modelConfirmation;

        public PaymentController(View.PaymentPage paymentPage) 
        {
            this.paymentPage = paymentPage;
            ModelPoli = new Model.ModelPoli();
            modelConfirmation = new Model.ModelConfirmation();
        }

        public void pay()
        {
            paymentPage.lblDrName.Content = DocInfo.docName;
            paymentPage.lblDrSpecialist.Content = ("Spesialis ") + DocInfo.docSpecial;
            paymentPage.lblConsultPrice1.Content =("Rp.") + ModelPoli.GetPrice().ToString();
            int tax = int.Parse((string)paymentPage.lblTaxPrice.Content);
            PaymenData.TotalPay = ModelPoli.GetPrice() + tax;
            paymentPage.TotalPrice.Content = ("Rp.") + PaymenData.TotalPay.ToString();
            

            Uri drPortrait = new Uri("/Image/" + DocInfo.docImage.ToString(), UriKind.Relative);
            paymentPage.docimage.Source = new BitmapImage(drPortrait);

        
        }

        public void PushTotal()
        {
            modelConfirmation.confirm();
            ModelPoli.GetPrice();
        }
    }
}

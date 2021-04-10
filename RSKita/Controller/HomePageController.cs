using RSKita.Data;
using RSKita.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace RSKita.Controller
{
    class HomePageController
    {
        private Model.ModelHomePage homePage;
        private Model.ModelPerson ModelPerson;
        private HomePage home;

        public HomePageController(HomePage home)
        {
            this.home = home;
            homePage = new Model.ModelHomePage();
            ModelPerson = new Model.ModelPerson();

        }

        public HomePageController()
        {
        }

        public void displayUser()
        {
            home.lblUserName.Content = "Selamat Datang \n" + UserInfo.userName.ToString();
        }

        public void displayticket()
        {
            home.docname.Content = DocInfo.docName;
            home.docspeical.Content = DocInfo.docSpecial;
            home.lbldate.Content = PaymenData.consultDate;
            home.lbltime.Content = PaymenData.consultTime;
            Uri drPortrait = new Uri("/Image/" + DocInfo.docImage.ToString(), UriKind.Relative);
            home.docimage.Source = new BitmapImage(drPortrait);
        }
    }
}

using RSKita.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace RSKita.Controller
{
    class HistoryPageController
    {
        private View.HistoryPage historyPage;

        public HistoryPageController(View.HistoryPage historyPage)
        {
            this.historyPage = historyPage;
        }

        public void showHistorydata()
        {
           historyPage.docname.Content = DocInfo.docName;
           historyPage.docspeical.Content = DocInfo.docSpecial;
            historyPage.lbldate.Content = PaymenData.consultDate;
            historyPage.lbltime.Content = PaymenData.consultTime;
            Uri drPortrait = new Uri("/Image/" + DocInfo.docImage.ToString(), UriKind.Relative);
            historyPage.docimage.Source = new BitmapImage(drPortrait);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RSKita.Controller
{
    class AppointmentController
    {
        View.DoctorPage doctorPage;
        Model.ModelAppointment modelAppointment;


        public AppointmentController(View.DoctorPage view)
        {
            this.doctorPage = view;
            modelAppointment = new Model.ModelAppointment();
        }

        public void getAptDate()
        {
           modelAppointment.Tgl_Konsultasi = Convert.ToDateTime(doctorPage.Datepicker.SelectedDate);

            if (doctorPage.rb8.IsChecked == true)
            {
                modelAppointment.Jam_konsultasi = "08:00";
            }
            else if (doctorPage.rb930.IsChecked == true)
            {
                modelAppointment.Jam_konsultasi = "09:30";
            }
            else if (doctorPage.rb13.IsChecked == true)
            {
                modelAppointment.Jam_konsultasi = "13:00";
            }
            else if (doctorPage.rb15.IsChecked == true)
            {
                modelAppointment.Jam_konsultasi = "15:00";
            }
            else
            {
                MessageBox.Show("Silahkan Pilih Jam");
            }
            int userID = int.Parse((string)UserInfo.userId);
            modelAppointment.Id_user = userID;
            modelAppointment.Id_doct = DocInfo.docId;
            modelAppointment.Id_rs = HospitalInfo.rsId;

            modelAppointment.MakeAppointment();
         
        }
    }
}

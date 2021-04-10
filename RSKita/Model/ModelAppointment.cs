using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RSKita.Model
{
    class ModelAppointment
    {
        private int aptID, userID;
        private DateTime consultDate;
        private string consultTime, rsID, docId;

        public int Kd_antrian { get { return aptID; } set { aptID = value; } }
        public string Jam_konsultasi { get { return consultTime; } set { consultTime = value; } }
        public DateTime Tgl_Konsultasi { get { return consultDate; } set { consultDate = value; } }
        public int Id_user { get { return userID; } set { userID= value; } }
        public string Id_rs { get { return rsID; } set { rsID = value; } }
        public string Id_doct { get { return docId; } set { docId = value; } }

        private SqlConnection connection;
        private SqlCommand command;

        private string query;
        private Boolean status;


        public ModelAppointment()
        {
            connection = DBConnection.GetConnection();
        }
        public bool MakeAppointment()
        {
            status = false;
            try
            {
                query = "INSERT INTO Pendaftaran VALUES ('" + consultTime + "','" + consultDate + "','" + userID + "','"+rsID +"','"+docId+"')";
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.ExecuteNonQuery();
                status = true;
                connection.Close();
            }
            catch (SqlException ex)
            {
                status = false;
                MessageBox.Show("error" + ex);
            }

            return status;
        }
    }
}

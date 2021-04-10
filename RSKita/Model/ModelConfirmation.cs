using RSKita.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSKita.Model
{
    class ModelConfirmation
    {

        private SqlConnection connection;
        private SqlCommand command;
        private string query;
        private bool result;

        private string consultTime;
        private DateTime consultDate;


        public DateTime Tgl_Konsultasi { get { return consultDate; } set { consultDate = value; } }
        public string Jam_konsultasi { get { return consultTime; } set { consultTime = value; } }

        public ModelConfirmation()
        {
            connection = DBConnection.GetConnection();
        }
        public void confirm()
        {

      
            query = "SELECT * from Pendaftaran where Id_user = '" + UserInfo.userId.ToString()+ "'";
            connection.Open();

            command = connection.CreateCommand();
            command.CommandText = query;

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
               PaymenData.consultDate = dataReader["Tgl_Konsultasi"].ToString();
              PaymenData.consultTime = dataReader["Jam_Konsultasi"].ToString();

            }

            connection.Close();

        }

    }
}


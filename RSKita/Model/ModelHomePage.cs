using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSKita.View;
using System.Windows;

namespace RSKita.Model
{
    class ModelHomePage
    {
        private SqlConnection connection;
        private SqlCommand command;
        private string query;
        private bool result;

        public ModelHomePage()
        {
            connection = DBConnection.GetConnection();
        }

        public string DisplayUser()
        {  

            string userdata = "";

            query = "SELECT * from Login";
            connection.Open();

            command = connection.CreateCommand();
            command.CommandText = query;

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {

                userdata = dataReader["Nama_User"].ToString();

            }

            connection.Close();
            return userdata;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;

namespace RSKita.Model
{
    class ModelPerson
    {
        private SqlConnection connection;
        private SqlCommand command;
        private string query;
        private string userData;
        private bool result;

        public ModelPerson()
        {
            connection = DBConnection.GetConnection();
        }

        private int userId;
        private string name, email, password, profileimg;

        public int Id_User { get { return userId; } set { userId = value; } }
        public string Nama_User { get { return name; } set { name = value; } }
        public string Email_User { get { return email; } set { email = value; } }
        public string Profile_image { get { return profileimg; } set { profileimg = value; } }
        public string Password_User { get { return password; } set { password = value; } }
        
        public bool LoginCheck()
        {
            try
            {

                query = "SELECT Email_User, Password_User from Login WHERE Email_User = '" + email + "' AND Password_User = '" + password + "'";
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = query;

                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    if (dataReader.GetString(0).ToString() == email && dataReader.GetString(1).ToString() == password)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            connection.Close();
            GetUserdata();
            return result;
        }

        public void GetUserdata()
        {
            query = "SELECT Id_User, Nama_User from Login WHERE Email_User = '" + email + "' AND Password_User = '" + password + "'";
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;

            SqlDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {
                UserInfo.userId = dr["Id_User"].ToString();
                UserInfo.userName = dr["Nama_User"].ToString();
            }
            connection.Close();
        }
           
    }
}

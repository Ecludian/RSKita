using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace RSKita.Model
{
    class ModelRegister
    {

        private int Id_User;
        public int idUser
        {
            get
            {
                return Id_User;
            }
            set
            {
                Id_User = value;
            }
        }
        private string Nama_User;
        public string namaUser
        {
            get
            {
                return Nama_User;
            }
            set
            {
                Nama_User = value;
            }
        }
        private string Email_User;
        public string emailUser
        {
            get
            {
                return Email_User;
            }
            set
            {
                Email_User = value;
            }
        }
        private string Password_User;
        public string passwordUser
        {
            get
            {
                return Password_User;
            }
            set
            {
                Password_User = value;
            }
        }
        private string Profile_image;
        public string profile_image
        {
            get
            {
                return Profile_image;
            }
            set
            {
                Profile_image = value;
            }
        }


        //interface data access


        private SqlConnection connection;
        private SqlCommand command;

        private string query;
        private Boolean status;


        public ModelRegister()
        {
            connection = DBConnection.GetConnection();
        }

        public bool Registeruser()
        {
            status = false;
            try
            {
                query = "INSERT INTO Login VALUES ('"+namaUser+"','"+emailUser+"','"+passwordUser+"')";
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.ExecuteNonQuery();
                status = true;
                connection.Close();
            }
            catch(SqlException ex)
            {
                status = false;
                MessageBox.Show("error" + ex);
            }
      
            return status;
        }
    }
}

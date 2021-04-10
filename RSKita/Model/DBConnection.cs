using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RSKita.Model
{
    class DBConnection
    {
        private static SqlConnection connection;

        public static SqlConnection GetConnection()
        {
            connection = new SqlConnection();

            connection.ConnectionString = "Data Source = DESKTOP-Q6O4JA0\\OBSIDIANNET;" +
                                          "Initial Catalog = RSkita;" +
                                          "Integrated Security = true;";

            return connection;
        }

        public void CheckConnection()
        {
            GetConnection();
            try
            {
                connection.Open();
                //MessageBox.Show("Authorized");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Failed" + ex);
            }
            connection.Close();
        }
    }
}

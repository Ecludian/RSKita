using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RSKita.Model
{
    class ModelHospital
    {
        private SqlConnection connection;
        private SqlCommand command;
        private string query;
        private View.HospitalPage2 hospitalPage;

        public ModelHospital()
        {
            connection = DBConnection.GetConnection();
        }
            private string rsId;
            private string rsName, rsAddress, docId, rsImage;
            private decimal rsRate;
            public string Id_rs { get { return rsId; } set { rsId = value; } }
            public string Nama_rs { get { return rsName; } set { rsName = value; } }
            public string Alamat_rs { get { return rsAddress; } set { rsAddress = value; } }
            public decimal Rate_rs { get { return rsRate; } set { rsRate = value; } }
            public string RS_image { get { return rsImage; } set { rsImage = value; } }
            public string Id_doct { get { return docId; } set { docId = value; } }



        public DataSet GetHospital()
        {
            DataSet data = new DataSet();
            try
            {
                connection.Open();
                query = "SELECT * FROM RSProfile";
                command = connection.CreateCommand();
                command.CommandText = query;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(data, "RSProfile");

                connection.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error : " + ex);
                connection.Close();
            }
            return data;
        }

        public void GetDoc()
        {
            query = "SELECT * FROM RSProfile WHERE Nama_rs = '"+ HospitalInfo.rsName.ToString() +"'";
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;

            SqlDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {
                HospitalInfo.rsId = dr["Id_rs"].ToString();
                HospitalInfo.rsName = dr["Nama_rs"].ToString();
                HospitalInfo.rsAddress = dr["Alamat_rs"].ToString();
                HospitalInfo.docId = dr["Id_doct"].ToString();
                HospitalInfo.rsImage = dr["RS_image"].ToString();
                HospitalInfo.rsRate = dr["Rate_rs"].ToString();
            }
            connection.Close();
        }

    }
}

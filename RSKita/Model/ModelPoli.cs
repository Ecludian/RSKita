using RSKita.Data;
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
    class ModelPoli
    {
        private SqlConnection connection;
        private SqlCommand command;
        private string query;

        public ModelPoli()
        {
            connection = DBConnection.GetConnection();
        }

        private string DocID, DocName, DocSpecial, DocSchedule,DocImage;
        private int docPrice;
        private bool status;

        //get docter
        public string Id_doct { get { return DocID; } set { DocID = value; } }
        public string Nama_doct { get { return DocName; } set { DocName = value; } }
        public string Spesialis_doct { get { return DocSpecial; } set { DocSpecial = value; } }
        public string DR_Image { get { return DocImage; } set { DocImage = value; } }
        public int Biaya_doct { get { return docPrice; } set { docPrice = value; } }
        public string Id_jadwal { get { return DocSchedule; } set { DocSchedule = value; } }

        //get schedule
        
        public string hari { get { return DocName; } set { DocName = value; } }
        public string shift { get { return DocSpecial; } set { DocSpecial = value; } }

        private int PaymentID, TotalPay;
        public int Kd_pembyaran { get { return PaymentID; } set { PaymentID = value; } }
        public int Total_pembayaran { get { return TotalPay; } set { TotalPay = value; } }
        public DataSet GetDoc()
        {
            DataSet data = new DataSet();
            try
            {
                connection.Open();
                query = "SELECT * FROM DoctProfile WHERE Id_doct ='" + HospitalInfo.docId.ToString() + "'";
                command = connection.CreateCommand();
                command.CommandText = query;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(data, "DoctProfile");

               
                connection.Close();
                GetDocInfo();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error : " + ex);
                connection.Close();

            }

            return data;
        }

        public void GetDocInfo()
        {
            query = "SELECT * FROM DoctProfile WHERE Id_doct ='" + HospitalInfo.docId.ToString() + "'";
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;

            SqlDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {

                DocInfo.docId = dr["Id_doct"].ToString();
                DocInfo.docName = dr["Nama_doct"].ToString();
                DocInfo.docSpecial = dr["Spesialis_doct"].ToString();
                DocInfo.docImage = dr["DR_Image"].ToString();
            }
            connection.Close();
        }

        public int GetPrice()
        {


            query = "SELECT Biaya_doct FROM DoctProfile WHERE Id_doct = '" + HospitalInfo.docId.ToString() + "'";

            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                docPrice= dataReader.GetInt32(0);
            }
            connection.Close();
            return docPrice;
        }

        public bool GetTotalPrice()
        {
            status = false;
            try
            {
                query = "INSERT INTO Pembayaran VALUES ('" +PaymenData.TotalPay+ "')";
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

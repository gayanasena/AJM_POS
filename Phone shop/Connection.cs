using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Phone_shop
{
    class Connection
    {
        static string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\AJM\AJMDB.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con;


        public void OpenConnection()
        {
            try
            {
                con = new SqlConnection(conStr);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error In Connection Opening - " + ex);
            }
        }

        public void CloseConnection()
        {
            con.Close();
        }

        public bool ExecuteQuary(string quary)
        {

            try
            {
                SqlCommand cmd = new SqlCommand(quary, con);
                cmd.ExecuteNonQuery();
                return (true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error In Quary - " + ex);
                return (false);
            }


        }

        public object ShowDataInView(string quary)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(quary, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                object dataum = ds.Tables[0];
                return dataum;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error In Quary - " + ex);
                return 0;
            }

        }

        public bool ReadDataLogin(string quary)
        {
            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ReadValues(string quary, string column)
        {
            string colVal = "";
            SqlCommand cmd = new SqlCommand(quary, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    colVal = rdr[column].ToString();
                }
                return colVal;
            }
            return colVal;


        }

        public object MenuDataGet(string quary)
        {
            SqlCommand cmd = new SqlCommand(quary, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            AutoCompleteStringCollection autotext = new AutoCompleteStringCollection();
            while (sdr.Read())
            {
                autotext.Add(sdr.GetString(0));
            }
            return autotext;
        }

    }
}

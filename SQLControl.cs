using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Login
{
    class SQLControl
    {
        private string conexionString;
        private SqlConnection cnn;
        private SqlCommand cmd;
        private DataTable table;

        public SQLControl()
        {
            conexionString = @"Data Source=DESKTOP-DIVRQKS\SERVIDORSQL;Initial Catalog=VIVERO_FENIX;Integrated Security=True";
            cnn = new SqlConnection(conexionString);
        }
        public DataTable ConsultarSQL(string query) 
        {
            cnn.Open();
            cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = cnn;
            table = new DataTable();
            table.Load(cmd.ExecuteReader());
            cnn.Close();
            return table;
        }
        

        public int Login (string usario, string pass) 
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("spLogin", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@usuario", usario);
                cmd.Parameters.AddWithValue("@pass", pass);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return dr.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally 
            {
                cnn.Close();
            }
            return -1;


        }

    }
}

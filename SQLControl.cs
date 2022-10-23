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
        private SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-DIVRQKS\SERVIDORSQL;Initial Catalog=VIVERO_FENIX;Integrated Security=True");

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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    public class ConnectDatabase
    {
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=test;Integrated Security=True");
        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}

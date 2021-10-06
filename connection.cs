using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace project
{
    class connection
    {
        SqlConnection con = new SqlConnection(@"Data Source=VALLABH\SQLEXPRESS;Initial Catalog=project;Integrated Security=True");
        public SqlConnection active()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
    }
}
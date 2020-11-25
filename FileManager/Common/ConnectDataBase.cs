using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Common
{
    class ConnectDataBase
    {
        public static SqlConnection GetDBConnection()
        {
            var connection = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connection);
            return conn;
        }
    }
}

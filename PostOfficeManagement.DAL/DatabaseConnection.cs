using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace PostOfficeManagement.DAL
{
    class DatabaseConnection
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["conStringPosta"].ConnectionString.ToString();

        public static SqlConnection sqlConnection;
        public static SqlDataAdapter sqlDataAdapter;
        public static SqlDataReader sqlDataReader;
        public static SqlCommand sqlCommand;

    }
}

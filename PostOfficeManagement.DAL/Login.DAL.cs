using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PostOfficeManagement.DAL
{
    public class Login
    {
        public DataSet GetAll()
        {
            try
            {
                using (DatabaseConnection.sqlConnection = new SqlConnection(DatabaseConnection.ConnectionString))
                {
                    DatabaseConnection.sqlConnection.Open();
                    DatabaseConnection.sqlDataAdapter = new SqlDataAdapter("usp_GetAllCitizenships", DatabaseConnection.sqlConnection);
                    DataSet ds = new DataSet();
                    DatabaseConnection.sqlDataAdapter.Fill(ds);
                    return ds;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration.Internal;
using System.Configuration;
using DAL.Infrastructure;

namespace DAL
{
    public class DALCountries
    {

        public static DataTable GetCountries() 
        {
            DataTable dtCountries = new DataTable("Countries");
            string query = "EXEC SP_GetCountries;";


            try
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString))
                {
                    connection.Open();
                    using (var cmd = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        dtCountries.Load(reader);
                    }
                }
            }
            catch (SqlException ex) 
            {
                throw new DataAccessException("Error occurred while retrieving countries data.", ex);
            }
            return dtCountries;
        }

    }
}

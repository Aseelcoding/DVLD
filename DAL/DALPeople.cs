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

    public class DALPeople
    {

        public static  DataTable GetAllPeople()
        {
            DataTable dtPeople = new DataTable("People");

            string query = " EXEC SP_GetAllPeople;";

            try 
            {
                using (var connection =new SqlConnection (ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString))
                {
                    connection.Open();
                    using (var cmd = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                     dtPeople.Load(reader); 
                    }

                       
                }
                
            }
            catch (SqlException ex)
            {
                throw new DataAccessException
                    (
                "Error occurred while retrieving people data.",ex);
            }

            return dtPeople;
        }

    }
}

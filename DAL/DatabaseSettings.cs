using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
namespace DAL
{
    public class DatabaseSettings
    {
        public readonly string connectionString =
    ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
    }
}

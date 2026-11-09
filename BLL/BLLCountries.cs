using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P_Exceptions;
using DAL;
namespace BLL
{
    public class BLLCountries
    {
        public static DataTable GetAllCountries()
        {
            DataTable dtCountries;
            try
            {
                dtCountries = DAL.DALCountries.GetCountries();
            }
            catch (DataOperationException ex)
            {
                throw new DataOperationException("Error retrieving countries: ", ex);
            }
            return dtCountries;
        }
    }
}

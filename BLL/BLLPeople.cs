using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Exceptions;
using DAL;
namespace BLL
{
    public class BLLPeople
    {
        public static  DataTable GetAllPeople() 
        {
            DataTable dtPeople;
            try 
            {
                dtPeople= DAL.DALPeople.GetAllPeople();
            }
            catch (DataOperationException ex)
            {
                throw new DataOperationException("Error retrieving people: " , ex);
            }

            return dtPeople;
        }
    }
}

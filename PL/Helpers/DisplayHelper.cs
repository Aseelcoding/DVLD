using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Helpers
{
    public class DisplayHelper
    {

        public static string GetGenderDisplayValue(int genderCode)
        {
            switch (genderCode)
            {
                case 0:
                    return "Male";
                case 1:
                    return "Female";
                default:
                    return "Unknown";
            }
        }

    }
}

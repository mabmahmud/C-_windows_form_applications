using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS2225_P2_Mohammad_Rahman.BusinessObject
{
    class ValidateForm
    {
        /*
        Method name:  IsEmpty
        Author:       Mohammad Rahman
        Description:  This method performs form validations if any field is empty
        Date:         2020-10-28
       */
        public static bool IsEmpty(string input)
        {
            if (input == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

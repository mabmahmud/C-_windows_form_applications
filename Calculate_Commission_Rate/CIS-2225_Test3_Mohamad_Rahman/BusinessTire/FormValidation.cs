using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Class name:        Form Validation              
Author:            Mohammad Rahman
Description:       This class is to validate all inputs are given by the user
Date:              2020-12-02
*/


namespace CIS_2225_Test3_Mohamad_Rahman.BusinessTire
{
    class FormValidation
    {
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

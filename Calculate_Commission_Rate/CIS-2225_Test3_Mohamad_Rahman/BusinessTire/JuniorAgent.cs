using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Class name:       Junior Agent              
Author:            Mohammad Rahman
Description:       This class is to hold all the properties of junior agent
Date:              2020-12-02
*/
namespace CIS_2225_Test3_Mohamad_Rahman.BusinessTire
{
    public class JuniorAgent : Agent
    {

        private bool isJunior;
        public JuniorAgent() { }

        public JuniorAgent(string lName, string fName, string email, double salesAmount, bool isJunior) :
            base(lName, fName, email, salesAmount)
        {
            this.isJunior = isJunior;
        }

        /*
        Method name:       CalculateCommission              
        Author:            Mohammad Rahman
        Description:       This method(derived) performs calculatoin of Commission of Junior agent
        Date:              2020-12-02
        */
        public override double CalculateCommission(bool isJunior)
        {
            double tempCommission = 0;
            tempCommission = base.CalculateCommission(false) - base.CalculateCommission(false) * (0.5 / 100.0);
            return tempCommission;
        }
    }
}

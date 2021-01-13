using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_2225_Test3_Mohamad_Rahman.BusinessTire
{
   public class SeniorAgent : Agent
    {

        //Default constructor
        public SeniorAgent() { }

        //Custom constructor that accept parameters from form class
        public SeniorAgent(string lName, string fName, string email, double salesAmount) : base(lName,
            fName, email, salesAmount)
        {

        }

        /*
        Method name:       CalculateCommission            
        Author:            Mohammad Rahman
        Description:       This method(derived) performs calculatoin of Commission of Senior agent
        Date:              2020-12-02
        */
        public override double CalculateCommission(bool isJunior)
        {
            double tempCommission = 0;
            tempCommission = base.CalculateCommission() + base.CalculateCommission(false) * (1.5 / 100.0);
            return tempCommission;
        }
    }
}

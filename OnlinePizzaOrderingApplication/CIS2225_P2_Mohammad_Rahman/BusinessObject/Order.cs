using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS2225_P2_Mohammad_Rahman.BusinessObject
{
    class Order
    {

        //Delcaring local variables
        public static List<string> orderDescription = new List<string>();

        public const double HAM_PRICE = 5.00;
        public const double SUB_PRICE = 6.00;
        public const double FISH_PRICE = 8.00;

        public string LastName { get; set; }
        public string FirstName { get; set; }  
        public int ComboOption { get; set; }
        public string MealType { get; set; }

        private double totalCostForHam = 0;
        private double totalCostForSub = 0;
        private double totalCostForFish = 0;

        private double comboOptionCost = 0;
        private double subtotal = 0;
        private double totalCost = 0;

        private int countHam = 0;
        private int countSub = 0;
        private int countFish = 0;





        /*
         Constructor type:  Default
         Author:            Mohammad Rahman
         Date:              2020-10-28
        */
        public Order() { }
        /*
         Constructor type:  Custom
         Author:            Mohammad Rahman
         Description:       Set values of the properties from main UI
         Date:              2020-10-28
        */
        public Order(string firstName, string lastName, int comboChoice, string mealType, int hamQ, int subQ, int fishQ)
        {
            FirstName = firstName;
            LastName = lastName;
            MealType = mealType;
            ComboOption = comboChoice;
            countHam = hamQ;
            countSub = subQ;
            countFish = fishQ;

            CalculateOrder();




            orderDescription.Add(ToString());
        }

        /*
         Method name:    CalculateOrder
         Author:         Mohammad Rahman
         Description:    Calculates order based on user inputs
         Date:           2020-10-28
        */
        private void CalculateOrder()
        {

            if (this.MealType.Contains("Hamburger"))
            {
                totalCostForHam = HAM_PRICE * countHam;
            }
            if (this.MealType.Contains("Sub"))
            {
                totalCostForSub = SUB_PRICE * countSub;
            }
            if (this.MealType.Contains("Fish"))
            {
                totalCostForFish = FISH_PRICE * countFish;
            }

            subtotal = totalCostForHam + totalCostForSub + totalCostForFish;

            switch (ComboOption)
            {
                case 0:
                    comboOptionCost = subtotal;
                    break;
                case 1:
                    comboOptionCost = subtotal * 0.5;
                    break;
                case 2:
                    comboOptionCost = subtotal * 0.75;
                    break;
            }
            totalCost = subtotal + comboOptionCost;
        }

        /*
        Method name:  ToString
        Author:       Mohammad Rahman
        Description:  Prepare individual object of an order as a string value 
        Date:         2020-10-28
       */
        public override string ToString()
        {

            string output = "";
            output = this.FirstName + " " + this.LastName + " Food Order\n";
            output += MealType.Contains("Hamburger") ? countHam + " Hamburger- \t" + totalCostForHam.ToString("C") + "\n" : "";
            output += MealType.Contains("Sub") ? +countSub + " Sub- \t" + totalCostForSub.ToString("C") + "\n" : "";
            output += MealType.Contains("Fish") ? +countFish + " Fish- \t" + totalCostForFish.ToString("C") + "\n" : "";
            output += "--------------------------------------------------------------\n";
            output += "Subtotal:\t\t\t" + subtotal.ToString("C") + " (Base meal cost)" + "\n";
            output += "Combo Meals Option:\t" + comboOptionCost.ToString("C") + "\n";
            output += "Meal Total Cost:\t\t" + totalCost.ToString("C") + "\n\n";
            output += "=================================================================\n";

            return output;
        }

    }
}

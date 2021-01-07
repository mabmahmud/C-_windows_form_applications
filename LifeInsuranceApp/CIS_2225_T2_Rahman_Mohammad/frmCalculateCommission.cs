/*
  Progam name:  Life Insurance Application
  Description:  Life insurance policy that calculates sales's person's commissin based on each sales as well all a summary for the total system with extended functionalities
  Date:          02 October, 2020
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_2225_T2_Rahman_Mohammad
{
    public partial class frmCalculateCommission : Form
    {
        public frmCalculateCommission()
        {
            InitializeComponent();
        }

        double commissionEarned = 0.00;
        public int countTotalSales = 0;

        private int countTotalPolicies = 0;

        // Button to show calculated commission
        private void btnCalculatrCommission_Click(object sender, EventArgs e)
        {
            calculateCommissionRAte();
        }

        // Boolean method to calculate commission rate 
        private bool calculateCommissionRAte()
        {

            double.TryParse(txtInsuranceAmount.Text, out double PolicyAmount);

            if (validateGeneralFields())
            {

                if (PolicyAmount >= 0 && PolicyAmount < 1000)
                {
                    commissionEarned = PolicyAmount * 0.05;
                    MessageBox.Show("Hello  " + txtFirstName.Text + " " + txtLastName.Text +
                         " " + "The commission dollar earned " + commissionEarned + " commission rate is 5%");
                    countTotalPolicies++;
                }
                if (PolicyAmount >= 1000 && PolicyAmount < 1000000)
                {
                    commissionEarned = PolicyAmount * 0.10;
                    MessageBox.Show("Hello  " + txtFirstName.Text + " " + txtLastName.Text +
                         " " + "The commission dollar earned " + commissionEarned + " commission rate is 10%");
                    countTotalPolicies++;
                }
                if(PolicyAmount >= 1000000)
                {
                    commissionEarned = PolicyAmount * 0.20;
                    MessageBox.Show("Hello  " + txtFirstName.Text + " " + txtLastName.Text +
                         " " + "The commission dollar earned " + commissionEarned + " commission rate is 20%");
                    countTotalPolicies++;
                }
                return true;
            }
            else
            {
                MessageBox.Show("Please enter first name, last name and policy amount.");
                return false;

            }


        }

        // Boolean method to varify the fields
        private bool validateGeneralFields()
        {
            //Validate general fields
            if (txtFirstName.Text == "")
            {
                return false;
            }
            if (txtLastName.Text == "")
            {
                return false;
            }
            if (txtInsuranceAmount.Text == "")
            {
                return false;
            }
            return true;
        }

        //Button to show summary
        private void btnSummary_Click(object sender, EventArgs e)
        {
            showSummary();

        }
        // Button to clear current sales person information
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtInsuranceAmount.Text = "";
        }

        // Button to clear all information
        private void btnAllClear_Click(object sender, EventArgs e)
        {
            showSummary();
            btnSummary.Controls.Clear();
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtInsuranceAmount.Text = "";

        }
        // Method to show the information in dialogue box
        private void showSummary()
        {
            MessageBox.Show("Total number of ploicies is " + countTotalPolicies + ". The total dollar insurance sold is " + txtInsuranceAmount.Text + ". Total commsion earned is " + commissionEarned + ".");
        }
    }
}

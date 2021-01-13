using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIS_2225_Test3_Mohamad_Rahman.BusinessTire;

/*
Class name:        MainUI              
Author:            Mohammad Rahman
Description:       This class is to calculate commission for agent based on their agent type, sales amount and show result 
Date:              2020-12-02
*/

namespace CIS_2225_Test3_Mohamad_Rahman
{

    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {


            //Agent newJuniorAgent;
            try
            {
                //Check validation
                if (FormValidation.IsEmpty(txtLastName.Text) && FormValidation.IsEmpty(txtFirstName.Text) &&
                FormValidation.IsEmpty(txtEmail.Text) && FormValidation.IsEmpty(txtSalesAmount.Text))
                {
                    MessageBox.Show("Validation failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //disable textBox control
                    txtLastName.Enabled = false;
                    txtFirstName.Enabled = false;
                    txtEmail.Enabled = false;
                    rbtnJuniorAgent.Enabled = false;
                    rbtnAgent.Enabled = false;
                    rbtnSeniorAgent.Enabled = false;
                    txtSalesAmount.Enabled = false;

                    //prepare result for displaying
                    richTextResult.Visible = true;
                    if (rbtnJuniorAgent.Checked == true)
                    {
                        JuniorAgent newJuniorAgent = new JuniorAgent(txtLastName.Text, txtFirstName.Text, txtEmail.Text,
                            double.Parse(txtSalesAmount.Text), true);
                        richTextResult.Text = "";
                        richTextResult.Text = "Junior Agent Commission Income Details\n\nTotal Commission: " + newJuniorAgent.CalculateCommission(true).ToString("C")
                                            + "\nCommission Rate: " + newJuniorAgent.GetCommissionRate()
                                            + "\n\nNote: Junior agent got 0.5% less commission than agent";
                    }
                    else if (rbtnAgent.Checked == true)
                    {
                        richTextResult.Text = "";
                        Agent aAgent = new Agent(txtLastName.Text, txtFirstName.Text, txtEmail.Text,
                            double.Parse(txtSalesAmount.Text));
                        richTextResult.Text = "Agent Commission Income Details\n\nTotal Commission: " + aAgent.CalculateCommission(true).ToString("C")
                                           + "\nCommission Rate: " + aAgent.GetCommissionRate();
                    }
                    else
                    {
                        richTextResult.Text = "";
                        SeniorAgent aSeniorAgent = new SeniorAgent(txtLastName.Text, txtFirstName.Text, txtEmail.Text,
                            double.Parse(txtSalesAmount.Text));
                        richTextResult.Text = "Senior Agent Commission Income Details\n\nTotal Commission: " + aSeniorAgent.CalculateCommission(true).ToString("C")
                                           + "\nCommission Rate: " + aSeniorAgent.GetCommissionRate();

                    }
                    this.Width = 750;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Validation failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

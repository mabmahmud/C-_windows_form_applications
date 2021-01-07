using CIS2225_P2_Mohammad_Rahman.BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS2225_P2_Mohammad_Rahman
{
    public partial class frmOrderSystem : Form
    {
        public frmOrderSystem()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxMealType_Enter(object sender, EventArgs e)
        {

        }

        private void placeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Declare local variables
            string mealType = "", firstName = "", lastName = "";
            int hamQty = 0, subQty = 0, fishQty = 0;


            lastName = txtLastName.Text;
            firstName = txtFirstName.Text;


            try
            {
                if (checkBoxHam.Checked)
                {
                    mealType += "Hamburger";
                    hamQty = int.Parse(txtHamQty.Text);
                }

                if (checkBoxSub.Checked)
                {
                    mealType += " Sub";
                    subQty = int.Parse(txtSubQty.Text);
                }
                if (checkBoxFish.Checked)
                {
                    mealType += " Fish";
                    fishQty = int.Parse(txtFishQty.Text);
                }
                int comboOption = cmbMealSelection.SelectedIndex;

                //Check validation
                if (!ValidateForm.IsEmpty(firstName) && !ValidateForm.IsEmpty(lastName)
                    && ((checkBoxHam.Checked && hamQty > 0) || (checkBoxSub.Checked && subQty > 0) ||
                    (checkBoxFish.Checked && fishQty > 0)) && comboOption >= 0)
                {
                    //If Validation is passed then place the order
                    Order aOrder = new Order(firstName, lastName, comboOption, mealType, hamQty, subQty, fishQty);
                    MessageBox.Show("Your order has been placed");
                }
                else
                {
                    MessageBox.Show("Validation failed");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input");
            }

        }

        private void checkOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Checkout and show order summary in order form
            frmSummary frmSum = new frmSummary();
            frmSum.Show();
            frmSum.richTextBoxSummary_TextChanged(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Exit the program
            this.Close();
            frmSummary frmSum = new frmSummary();
            frmSum.Close();
        }
    }
}

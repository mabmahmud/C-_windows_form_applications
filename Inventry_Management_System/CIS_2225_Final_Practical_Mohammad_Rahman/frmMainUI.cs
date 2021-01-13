using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_2225_Final_Practical_Mohammad_Rahman
{
    public partial class frmMainUI : Form
    {

        BusinessTire Prod;

        public frmMainUI()
        {
            InitializeComponent();
        }


        /*
       Method name: frmMianUI_Load
       Author: Mohammad Rahman
       Description: Load product ids into combobox
       */
        private void frmMainUI_Load(object sender, EventArgs e)
        {
            Prod = new BusinessTire();
            List<string> prodIds = Prod.LoadProdIds();
            for (int i = 0; i < prodIds.Count; i++)
            {
                cmbProductID.Items.Add(prodIds[i]);
            }
        }

        /*
         Method name: cmbProductID_SelectedIndexChanged
         Author: Mohammad Rahman
         Description: Load product ids into combobox

        */
        private void cmbProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Prod = new BusinessTire();
            Prod.ProductId = cmbProductID.SelectedItem.ToString();
            Prod.Search();

            cmbProductID.Text = cmbProductID.SelectedItem.ToString();
            txtDescription.Text = Prod.Description;
            txtPrice.Text = Prod.Price;
            txtQantity.Text = Prod.Quantity;
            txtMarkUp.Text = Prod.MarkUp;
        }

        /*
        Method name: btnClear_Click
        Author: Mohammad Rahman
        Description: Trigers for clearing textboxes
        */
        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbProductID.SelectedItem = -1;
            txtDescription.Text = "";
            txtPrice.Text = "";
            txtQantity.Text = "";
            txtMarkUp.Text = "";

        }

        /*
         Method name: btnAdd_Click
         Author: Mohammad Rahman
         Description: Trigers for adding object
        */
        private void btnAdd_Click(object sender, EventArgs e)
        {

            //Check validation
            if (txtDescription.Text == "" || txtPrice.Text == "" || !IsNumber(txtPrice.Text)
                || txtQantity.Text == "" || !IsNumber(txtQantity.Text) || txtMarkUp.Text == ""
                || !IsNumber(txtMarkUp.Text))
            {
                MessageBox.Show("Validation failed", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //If validation is passed add the object as following
            else
            {
                Prod = new BusinessTire();
                Prod.Description = txtDescription.Text.ToString();
                Prod.Price = txtPrice.Text.ToString();
                Prod.Quantity = txtQantity.Text.ToString();
                Prod.MarkUp = txtMarkUp.Text.ToString();

                Prod.Add();

                MessageBox.Show("Record insertedsuccessfully");

                txtDescription.Text = "";
                txtPrice.Text = "";
                txtQantity.Text = "";
                txtMarkUp.Text = "";
            }
        }

        /*
         Method name: btnDelete_Click
         Author: Mohammad Rahman
         Description: Trigers for deleting object
        */
        private void btnDelete_Click(object sender, EventArgs e)
        {

            Prod = new BusinessTire();

            if(cmbProductID.SelectedItem == null)
            {
                MessageBox.Show("There is no product to delete");
            }
            else
            {
                    MessageBox.Show("Are you sure? you want to delete this record ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Prod.ProductId = cmbProductID.SelectedItem.ToString();

                    Prod.Delete();
                    
                    cmbProductID.SelectedItem = -1;
                    txtDescription.Text = "";
                    txtPrice.Text = "";
                    txtQantity.Text = "";
                    txtMarkUp.Text = "";    
            }

        }

        /*
         Method name: IsNumber
         Author: Mohammad Rahman
         Description: Chekc validation for number
        */
        private bool IsNumber(string value)
        {
            int number;
            bool success = Int32.TryParse(value, out number);

            if (success)
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

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
    public partial class frmSummary : Form
    {
        public frmSummary()
        {
            InitializeComponent();
        }

        public void richTextBoxSummary_TextChanged(object sender, EventArgs e)
        {

            string resutl = "";
            if (Order.orderDescription.Count > 0)
            {
                foreach (var item in Order.orderDescription)
                {
                    resutl += item;
                }
            }
            else
            {
                resutl = "No order has been placed yet!";
            }
            richTextBoxSummary.Text = resutl;
        }
    }
}

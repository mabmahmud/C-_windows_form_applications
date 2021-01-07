using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 Author:       Mohammad Rahman
 Subject :     CIS-2225
 Date:         2020-11-06
 Assignment:   04
*/


namespace CIS_2225_T4_Rahman_Mohammad
{
    public partial class frmMDIParent : Form
    {
        public frmMDIParent()
        {
            InitializeComponent();
        }

        int docCounter = 0;
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {


            frmMDIChild frmChild = new frmMDIChild();
            frmChild.frmMDIParent = this;

            ofdOpen.InitialDirectory = "C:";
            ofdOpen.Title = "Open File";
            ofdOpen.FileName = "";
            ofdOpen.Filter = "All files|*.*|Text Files|*.txt|JPEG Images|*.jpg";

            ofdOpen.ShowDialog();

            try
            {
                System.IO.StreamReader sReader = new System.IO.StreamReader(ofdOpen.FileName);
                frmChild.Show();
                frmChild.displayTextInRichTextBox(sReader);
                frmChild.Text = ofdOpen.FileName;
            }
            catch (ArgumentException)
            {
                frmChild.Show();
                frmChild.displayTextInRichTextBox(null);
            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {

            docCounter++;
            frmMDIChild frmChild = new frmMDIChild();
            frmChild.frmMDIParent = this;
            frmChild.Show();
            frmChild.Text = "Document " + docCounter;
        }

        private void frmMDIParent_Load(object sender, EventArgs e)
        {

        }
    }
}

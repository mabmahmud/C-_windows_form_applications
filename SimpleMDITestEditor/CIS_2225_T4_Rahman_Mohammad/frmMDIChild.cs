
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
    public partial class frmMDIChild : Form
    {
        internal frmMDIParent frmMDIParent;

        public frmMDIChild()
        {
            InitializeComponent();
        }

        private void frmMDIChild_Load(object sender, EventArgs e)
        {

            tspLblDate.Text = DateTime.Now.ToShortDateString();
            tspLblTime.Text = DateTime.Now.ToLongTimeString();
        }

        public void richTextBoxDisplay_TextChanged(object sender, EventArgs e)
        {
         
        }


        public void displayTextInRichTextBox(System.IO.StreamReader sReader)
        {
            if (sReader != null)
            {
                richTextBoxDisplay.Text = sReader.ReadToEnd();
                //this.Text = openFileDialog1.FileName;
            }
            else
            {
                MessageBox.Show("No file is chosen!");
            }

        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {

            ofdOpen.InitialDirectory = "C:";
            ofdOpen.Title = "Open File";
            ofdOpen.FileName = "";
            ofdOpen.Filter = "All files|*.*|Text Files|*.txt|JPEG Images|*.jpg";

            ofdOpen.ShowDialog();

            try
            {
                System.IO.StreamReader sReader = new System.IO.StreamReader(ofdOpen.FileName);

                displayTextInRichTextBox(sReader);

                this.Text = ofdOpen.FileName;
            }
            catch (ArgumentException)
            {
                displayTextInRichTextBox(null);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            saveToolStripMenuItem_Click(sender, e);
 
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tspLblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Check Validation
            if (richTextBoxDisplay.Text == "")
            {
                MessageBox.Show("File is empty");
            }
            //Save file if validation is passed
            else
            {
                sfdSave.InitialDirectory = "C:";
                sfdSave.Title = "Save File";
                sfdSave.FileName = " ";
                sfdSave.Filter = "Text Files|.txt|Word Document|.doc";

                richTextBoxDisplay.Text += "\nDate Written: " + dateTimePicker1.Value; ;
                if (sfdSave.ShowDialog() == DialogResult.OK)
                {
                    richTextBoxDisplay.SaveFile(sfdSave.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }
    }
}

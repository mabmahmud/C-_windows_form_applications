

/*
  Progam name:  pH Level Tracker
  Writen by: Mohamamd Rahman
  Date : 18/09/2020
  Description: To show pH level and erequired action based on user input
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

namespace CIS2225_A1_Rahman_Mohammad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // To show data based on user iinput
        private void button1_Click(object sender, EventArgs e)
        {
             String input = this.inputPHLevel.Text;
            double pHLevel;

            if (double.TryParse(input, out pHLevel))
            {
                ShowResults(pHLevel);
            }
            else
            {
                MessageBox.Show("The pH level is out of range");
            }


        }

        // Calculate pH level and display specific message based on pH level input
        private void ShowResults(double pHLevel)
        {
            String displayText = "";

            if (pHLevel >= 0 && pHLevel < 7.2)
            {
                if (pHLevel == 7)
                {
                    displayText = "The pH level is  " + pHLevel + " and its is 'Neutral'.";
                    ShowMessage(displayText);
                    displayText = " ";
                }
                else
                {
                    displayText = "The pH level is " +pHLevel +" .It is called 'Acidic' and needs pH increasers(bases) to balance pH Level.";
                    ShowMessage(displayText);
                    displayText = "";
                }
            }

            else if (pHLevel > 7.8 && pHLevel <= 14)
            {
                displayText = "The pH level is " + pHLevel + " .It is called 'Basic or Alkaline' and needs pH decreaser(acids) to balance pH Level.";
                ShowMessage(displayText);
                displayText = "";
            }

            else if (pHLevel >= 7.2 && pHLevel <= 7.8)
            {
                MessageBox.Show("Balanced");
            }
            else
            {
                displayResults.Text = "pH input level scale must be between 0 - 14";
                displayResults.Focus();
                MessageBox.Show("pH input level scale must be between 0 - 14");
            }
        }

        // Display message in text box
        private void ShowMessage(String message)
        {
            displayResults.Text = message;
        }

        // Reset the form to cleaer input and message
        private void button2_Click(object sender, EventArgs e)
        {
            inputPHLevel.Text = "";
            displayResults.Text = "Result will be displayed here..";
            displayResults.ForeColor = Color.Black;
            inputPHLevel.Focus();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

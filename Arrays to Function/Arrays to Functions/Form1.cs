using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays_to_Functions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double processing (string[] sNumbers)
        {
            //Declaring all variables used.
            int iArrayLength = 0;
            int iArrayCounter = 0;
            double dTemp = 0;
            double dTotal = 0;

            /*
            Most efficient method which should probably be used.
            for (int i = 0; i < sNumbers.Length; i++)
            {
                if (Double.TryParse(sNumbers[i], out dTemp) == true)
                {
                    dTotal += dTemp;
                }
            }
            */
            //Find the amount of numbers within the string array.
            for (int i = 0; i < sNumbers.Length; i++)
            {
                //Checks if the number is a double value.
                if (Double.TryParse(sNumbers[i], out dTemp) == true)
                {
                    //Adds one to the array length int variable to be used later to set the size of the double array.
                    iArrayLength++;
                }
            }
            //Make the array of numbers equal length to the amount of numbers in the string array.
            double[] dNumbers = new double[iArrayLength];

            //Populate the double array with the content from the string array.
            for (int i = 0; i < sNumbers.Length; i++)
            {
                //Checks if the number is a double value.
                if (Double.TryParse(sNumbers[i], out dTemp) == true)
                {
                    //Populate the double array with the current value in the string array. I'm using the output from the tryparse to do this.
                    dNumbers[iArrayCounter] = dTemp;
                    iArrayCounter++;
                }
            }
            
            //Iterate through the double array to add each number.
            for(int i = 0; i < dNumbers.Length;i++)
            {
                dTotal += dNumbers[i];
            }
            //Return the total.
            return (dTotal);
        }
        
        private void btnGo1_Click(object sender, EventArgs e)
        {
            //String array which contains all content of the text box split by new lines.
            string[] sNumbers = txtNumbers1.Text.Split('\n');
            //Calls the function to process the inputted values. Sets the total variable to the returned value.
            double dTotal = processing(sNumbers);
            //Outputs the total to the text box.
            txtTotal1.Text = dTotal.ToString();
        }

        private void btnGo2_Click(object sender, EventArgs e)
        {
            string[] sNumbers = txtNumbers1.Text.Split('\n');
            double dTotal = processing(sNumbers);
            txtTotal2.Text = dTotal.ToString();
        }
    }
}

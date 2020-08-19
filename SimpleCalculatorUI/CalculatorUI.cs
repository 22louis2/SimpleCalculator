using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleCalcLibrary;

namespace SimpleCalcUI
{
    public partial class CalculatorUI : Form
    {
        // Declaring my variables
        double firstNumber = 0;
        double secondNumber = 0;
        string operation = "";
        bool enter_value = false;
        bool equalPressed = false;

        // Property Created
        public ISimpleCalcRepository Res { get; set; }

        // Passing the Interface Class
        public CalculatorUI(ISimpleCalcRepository res)
        {
            InitializeComponent();
            this.Res = res;
        }

        private void BtnNumeric(object sender, EventArgs e)
        {
            /*
             * Checking if an equator has been pressed
             * and number is clicked afterwards
             * return the number 
            */
            if (equalPressed)
            {
                txtDisplay.Text = "0";
                equalPressed = false;
            }

            // The object that invoked this event fired by the event handler
            Button b = (Button)sender;

            // Checking if the text is zero or the value entered is true
            if ((txtDisplay.Text == "0") || (enter_value))
                txtDisplay.Text = "";

            enter_value = false;

            // If the text entered is dot
            if (b.Text == ".")
            {
               // If the text does not contain dot, append it to the text, else don't
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text += b.Text;
            }
            else
                // Adding every other text to the TextBox display
                txtDisplay.Text += b.Text;
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            // Inbuilt Method to copy a text from screen
            Clipboard.SetText(txtDisplay.Text);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // In-built method to clear TextBox display
            txtDisplay.Clear();
            //txtDisplay.Text = "0";
            /*
             * Clear the operation sign, label text and 
             * Turn first and second number inputted to zero
            */
            operation = "";
            lblShowOp.Text = "";
            firstNumber = secondNumber = 0;
        }

        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            /*
             * Removing the last inputted text on the TextBox display and
             * Reducing its length
            */
            if (txtDisplay.TextLength > 1)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            else
            {
                // If the text is less than 1, turn the Text displayed to 0
                txtDisplay.Text = "0";
            }
        }

        private void ArithmeticOperator(object sender, EventArgs e)
        {
            // The object that invoked this event fired by the event handler
            Button num = (Button)sender;

            /*
             * Check if the first number is not equal to and the "=" sign 
             * is not true
            */
            if (firstNumber != 0 && !equalPressed)
            {
                /* 
                 * Perform a click event for the equality button
                 * store the operator sign object clicked in its operation
                 * Turn the enter value to true
                 * Place first number and the operation in the label container
                 */
                BtnEquality.PerformClick();
                operation = num.Text;
                enter_value = true;
                lblShowOp.Text = firstNumber + " " + operation;
            }

            /*
             * Do a TryParse on the TextBox text passed
             */
            double d;
            operation = num.Text;
            if (double.TryParse(txtDisplay.Text, out d))
            {
                firstNumber = double.Parse(txtDisplay.Text);
            } 
            /*
             * Turn the TextBox text to empty literal
             * Turn enter value to true
             * Display the first number and operation in the label container
            */
            txtDisplay.Text = "";
            enter_value = true;
            lblShowOp.Text = firstNumber + " " + operation;
        }

        private void BtnEquality_Click(object sender, EventArgs e)
        {
            // Turn Equality operator to true for pressed and set the label to empty literal
            equalPressed = true;
            lblShowOp.Text = "";
            
            // The Text inputted after the event that that invoked this method
            string secondNumber = txtDisplay.Text;

            // Checking if the operation passed through is empty literal
            if (operation == "") return;

            try
            {
                // Pass and Perform the Equality Method passed through and return its resulted string
                txtDisplay.Text = Res.Equality(operation, firstNumber.ToString(), secondNumber);
            }
            catch(Exception ex)
            {
                // Else, if an error occurs, display it to the user
                MessageBox.Show(ex.Message);
            }

            /*
             * To a try pass of its response before allocated it to first number
             * for next operation to be performed
            */
            double d;
            if (Double.TryParse(txtDisplay.Text, out d))
            {
                firstNumber = double.Parse(txtDisplay.Text);
            }

            // Turn Label container to an empty literal
            lblShowOp.Text = "";
        }


        private void BtnNegator_Click(object sender, EventArgs e)
        {
            // Check if TextBox text is not 0, before performing the conditions
            if(txtDisplay.Text != "0")
            {
                // Very the Text by running a TryParse on the TextBox Text
                double d;
                if(double.TryParse(txtDisplay.Text, out d)) {
                    /* 
                     * Multiply the TextBox text by -1
                     * After converting it to a double
                     * and then converting it back to a string
                     */ 
                    txtDisplay.Text = (Convert.ToDouble(txtDisplay.Text) * -1).ToString();
                }  
            }
            
        }
    }
}

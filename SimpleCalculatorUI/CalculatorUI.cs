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
        public ISimpleCalcRepository Res { get; set; }
        public CalculatorUI(ISimpleCalcRepository res)
        {
            InitializeComponent();
            this.Res = res;
        }

        double firstNumber = 0;
        string operation = "";
        bool enter_value = false;
        bool equalPressed = false;

        private void BtnNumeric(object sender, EventArgs e)
        {
            if (equalPressed)
            {
                txtDisplay.Text = "0";
                equalPressed = false;
            }
            Button b = (Button)sender;

            if ((txtDisplay.Text == "0") || (enter_value))
                txtDisplay.Text = "";
            enter_value = false;


            if (b.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text += b.Text;
            }
            else
                txtDisplay.Text += b.Text;
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtDisplay.Text);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.Text = "0";
            operation = "";
            lblShowOp.Text = "";
        }

        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.TextLength > 1)
            {
                //double d;
                //if (!double.TryParse(txtDisplay.Text[txtDisplay.Text.Length - 1].ToString(), out d))
                //{
                //    previousOperation = Operation.None;
                //}
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            else
            {
                txtDisplay.Text = "0";
            }
        }

        private void BtnEquality_Click(object sender, EventArgs e)
        {
            equalPressed = true;
            lblShowOp.Text = "";
            string number = firstNumber.ToString();
            string secondNumber = txtDisplay.Text;
            // Res.Equality(operation, number, secondNumber);
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = Res.Plus(number, secondNumber);
                    break;
                case "-":
                    txtDisplay.Text = Res.Minus(number, secondNumber);
                    break;
                case "*":
                    txtDisplay.Text = Res.Times(number, secondNumber);
                    break;
                case "/":
                    try
                    {
                        txtDisplay.Text = Res.Divide(number, secondNumber);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }

            firstNumber = double.Parse(txtDisplay.Text);
            operation = "";
        }


        private void BtnNegator_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text != "0")
            {            
                txtDisplay.Text = (Convert.ToDouble(txtDisplay.Text) * -1).ToString();
            }
            
        }

        private void ArithmeticOperator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (firstNumber != 0)
            {
                BtnEquality.PerformClick();
                operation = num.Text;
                enter_value = true;
                lblShowOp.Text = firstNumber + " " + operation;
            }
            else
            {
                operation = num.Text;
                firstNumber = Double.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
                enter_value = true;
                lblShowOp.Text = firstNumber + " " + operation;
            }
        }
    }
}

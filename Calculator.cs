using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        //first number
        decimal decNum1;
        //second number
        decimal decNum2;
        //decimal can only be used once
        bool decimalFlag = false;
        //additional variables
        string INPUT;
        int operatorFlag = 0;
        string result;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
        //Methods
        //changes what is displayed(which is a string) into a decimal
        private decimal DecConvert(string str, bool decFlag)
        {
            //variables
            int num1 = 0;
            int num2 = 0;
            int num = 0;
            int precision = 0;
            decimal factor = 0;

            //Change the string to a decimal
            if (decFlag == true)
            {
                string[] NUM = str.Split('.');
                Int32.TryParse(NUM[0], out num1);
                Int32.TryParse(NUM[1], out num2);
                precision = num2.ToString().Length;
                factor = (decimal)Math.Pow(10, -1 * precision);
                Int32.TryParse(num1.ToString() + num2.ToString(), out num);
                return num * factor;
            }
            //if there is no decimal
            else
            {
                Int32.TryParse(str, out num);
                return Convert.ToDecimal(num);
            }
        }
        //good housekeeping (I guess)
        private void ClearDisplayResetDecimalFlag()
        {
            DisplayBox.Clear();
            decimalFlag = false;
        }
        //Numbers
        private void Zero_Click(object sender, EventArgs e)
        {
            INPUT = "0";
            DisplayBox.Text = DisplayBox.Text + INPUT;
        }

        private void One_Click(object sender, EventArgs e)
        {
            INPUT = "1";
            DisplayBox.Text = DisplayBox.Text + INPUT;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            INPUT = "2";
            DisplayBox.Text = DisplayBox.Text + INPUT;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            INPUT = "3";
            DisplayBox.Text = DisplayBox.Text + INPUT;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            INPUT = "4";
            DisplayBox.Text = DisplayBox.Text + INPUT;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            INPUT = "5";
            DisplayBox.Text = DisplayBox.Text + INPUT;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            INPUT = "6";
            DisplayBox.Text = DisplayBox.Text + INPUT;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            INPUT = "7";
            DisplayBox.Text = DisplayBox.Text + INPUT;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            INPUT = "8";
            DisplayBox.Text = DisplayBox.Text + INPUT;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            INPUT = "9";
            DisplayBox.Text = DisplayBox.Text + INPUT;
        }
        //Decimal
        private void Decimal_Click(object sender, EventArgs e)
        {
            if(decimalFlag != true)
            {
                INPUT = ".";
                decimalFlag = true;
                DisplayBox.Text = DisplayBox.Text + INPUT;
            }else
            {
                DisplayBox.Text = "No more Decimals";
            }

        }
        //Operations
        private void Add_Click(object sender, EventArgs e)
        {
            //First Number assignment
            if (decNum1 == 0)
            {
                decNum1 = DecConvert(DisplayBox.Text, decimalFlag);
                ClearDisplayResetDecimalFlag();
            }
            //Operator Assignment
            if(operatorFlag == 0)
            {
                operatorFlag = 1;
            }
            else
            {
                DisplayBox.Text = "no more operators input";

            }

        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            //First Number assignment
            if (decNum1 == 0)
            {
                decNum1 = DecConvert(DisplayBox.Text, decimalFlag);
                ClearDisplayResetDecimalFlag();
            }
            //Operator Assignment
            if (operatorFlag == 0)
            {
                operatorFlag = 2;
            }
            else
            {
                DisplayBox.Text = "no more operators input";
            }
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            //First Number assignment
            if (decNum1 == 0)
            {
                decNum1 = DecConvert(DisplayBox.Text, decimalFlag);
                ClearDisplayResetDecimalFlag();
            }
            //Operator Assignment
            if (operatorFlag == 0)
            {
                operatorFlag = 3;
            }
            else
            {
                DisplayBox.Text = "no more operators input";
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            //First Number assignment
            if (decNum1 == 0)
            {
                decNum1 = DecConvert(DisplayBox.Text, decimalFlag);
                ClearDisplayResetDecimalFlag();
            }
            //Operator Assignment
            if (operatorFlag == 0)
            {
                operatorFlag = 4;
            }
            else
            {
                DisplayBox.Text = "no more operators input";
            }
        }
        //Result
        private void EqualsToEnter_Click(object sender, EventArgs e)
        {
            
            if(operatorFlag == 1)
            {
                //Second Number Assignment
                if (decNum2 == 0)
                {
                    decNum2 = DecConvert(DisplayBox.Text, decimalFlag);
                    ClearDisplayResetDecimalFlag();
                }
                result = (decNum1 + decNum2).ToString();
                DisplayBox.Text = result;
            }
            else if(operatorFlag == 2)
            {
                //Second Number Assignment
                if (decNum2 == 0)
                {
                    decNum2 = DecConvert(DisplayBox.Text, decimalFlag);
                    ClearDisplayResetDecimalFlag();
                }
                result = (decNum1 - decNum2).ToString();
                DisplayBox.Text = result;
            }
            else if(operatorFlag == 3)
            {
                //Second Number Assignment
                if (decNum2 == 0)
                {
                    decNum2 = DecConvert(DisplayBox.Text, decimalFlag);
                    ClearDisplayResetDecimalFlag();
                }
                result = (decNum1 * decNum2).ToString();
                DisplayBox.Text = result;

            }
            else if(operatorFlag == 4)
            {
                //Second Number Assignment
                if (decNum2 == 0)
                {
                    decNum2 = DecConvert(DisplayBox.Text, decimalFlag);
                    ClearDisplayResetDecimalFlag();
                }
                result = (decNum1 / decNum2).ToString();
                DisplayBox.Text = result;

            }
            else if(decNum1 > 0)
            {
                result = decNum1.ToString();
                DisplayBox.Text = result;

            }
            else
            {
                DisplayBox.Text = "There is nothing to operate on!";
            }
            operatorFlag = 0;
            decNum1 = 0;
            decNum2 = 0;

        }
        //Clear
        private void Clear_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = "";
            operatorFlag = 0;
            decimalFlag = false;
            decNum1 = 0;
            decNum2 = 0;
        }

    }

}

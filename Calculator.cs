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
        int num1 = 0;
        int num2 = 0;
        string NUM;
        int flag = 0;
        string result;

        public Calculator()
        {
            InitializeComponent();
        }



        private void Calculator_Load(object sender, EventArgs e)
        {

        }
        //Numbers
        private void Zero_Click(object sender, EventArgs e)
        {
            NUM = "0";

            DisplayBox.Text = DisplayBox.Text + NUM;

        }

        private void One_Click(object sender, EventArgs e)
        {
            NUM = "1";

            DisplayBox.Text = DisplayBox.Text + NUM;

        }

        private void Two_Click(object sender, EventArgs e)
        {
            NUM = "2";

            DisplayBox.Text = DisplayBox.Text + NUM;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            NUM = "3";

            DisplayBox.Text = DisplayBox.Text + NUM;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            NUM = "4";

            DisplayBox.Text = DisplayBox.Text + NUM;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            NUM = "5";

            DisplayBox.Text = DisplayBox.Text + NUM;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            NUM = "6";

            DisplayBox.Text = DisplayBox.Text + NUM;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            NUM = "7";

            DisplayBox.Text = DisplayBox.Text + NUM;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            NUM = "8";

            DisplayBox.Text = DisplayBox.Text + NUM;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            NUM = "9";

            DisplayBox.Text = DisplayBox.Text + NUM;
        }
        //Operations
        private void Add_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                Int32.TryParse(DisplayBox.Text, out num1);
                DisplayBox.Clear();
            }

            if(flag == 0)
            {
                flag = 1;
            }
            else
            {
                DisplayBox.Text = "no more flag input";

            }

        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                Int32.TryParse(DisplayBox.Text, out num1);
                DisplayBox.ResetText();
            }

            if (flag == 0)
            {
                flag = 2;
            }
            else
            {
                DisplayBox.Text = "no more flag input";
            }
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                Int32.TryParse(DisplayBox.Text, out num1);
                DisplayBox.ResetText();
            }

            if (flag == 0)
            {
                flag = 3;
            }
            else
            {
                DisplayBox.Text = "no more flag input";
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                Int32.TryParse(DisplayBox.Text, out num1);
                DisplayBox.ResetText();
            }

            if (flag == 0)
            {
                flag = 4;
            }
            else
            {
                DisplayBox.Text = "no more flag input";
            }
        }
        //Result
        private void EqualsToEnter_Click(object sender, EventArgs e)
        {
            
            if(flag == 1)
            {
                Int32.TryParse(DisplayBox.Text, out num2);
                result = (num1 + num2).ToString();
                DisplayBox.Text = result;
            }
            else if(flag == 2)
            {
                Int32.TryParse(DisplayBox.Text, out num2);
                result = (num1 - num2).ToString();
                DisplayBox.Text = result;
            }
            else if(flag == 3)
            {
                Int32.TryParse(DisplayBox.Text, out num2);
                result = (num1 * num2).ToString();
                DisplayBox.Text = result;

            }
            else if(flag == 4)
            {
                Int32.TryParse(DisplayBox.Text, out num2);
                result = (num1 / num2).ToString();
                DisplayBox.Text = result;

            }
            else if(num1 > 0)
            {
                result = num1.ToString();
                DisplayBox.Text = result;

            }
            else
            {
                DisplayBox.Text = "There is nothing to operate on!";
            }
            flag = 0;
            num1 = 0;
            num2 = 0;

        }
        //Clear
        private void Clear_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = "";
            flag = 0;
            num1 = 0;
            num2 = 0;
        }
    }
}

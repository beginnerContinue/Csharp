using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.calculator
{
    public partial class Form1 : Form
    {

        bool sign = false;
        int operatorFlag = 0;
        int temp = 0;
        int first = 0;
        int second = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, EventArgs e)
        {
            if(sign == false)
            {
                temp = 1;
                first = 1;
            }
            else
            {
                second = 1;
            }
            calDisplay.Text = "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (sign == false)
            {
                temp = 2;
                first = 2;
            }
            else
            {
                second = 2;
            }
            calDisplay.Text = "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (sign == false)
            {
                temp = 3;
                first = 3;
            }
            else
            {
                second = 3;
            }
            calDisplay.Text = "3";
        }
        private void four_Click(object sender, EventArgs e)
        {
            if (sign == false)
            {
                temp = 4;
                first = 4;
            }
            else
            {
                second = 4;
            }
            calDisplay.Text = "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (sign == false)
            {
                temp = 5;
                first = 5;
            }
            else
            {
                second = 5;
            }
            calDisplay.Text = "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (sign == false)
            {
                temp = 6;
                first = 6;
            }
            else
            {
                second = 6;
            }
            calDisplay.Text = "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (sign == false)
            {
                temp = 7;
                first = 7;
            }
            else
            {
                second = 7;
            }
            calDisplay.Text = "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (sign == false)
            {
                temp = 8;
                first = 8;
            }
            else
            {
                second = 8;
            }
            calDisplay.Text = "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (sign == false)
            {
                temp = 9;
                first = 9;
            }
            else
            {
                second = 9;
            }
            calDisplay.Text = "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (sign == false)
            {
                first = 0;
            }
            else
            {
                second = 0;
            }
            calDisplay.Text = "0";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            sign = true;
            operatorFlag = 1;
            temp += second;

        }

        private void minus_Click(object sender, EventArgs e)
        {
            sign = true;
            operatorFlag = 2;
            temp -= second;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            
            
            int result = 0;
            if(operatorFlag == 1){
                result = temp + second;
            }
            else if(operatorFlag == 2)
            {
                result = temp - second;
            }
            temp = result;
            second = 0;
            sign = false;
            operatorFlag = 0;
            calDisplay.Text = result.ToString();

        }

        private void clear_Click(object sender, EventArgs e)
        {
            first = 0;
            operatorFlag = 0;
            second = 0;
            sign = false;
            calDisplay.Text = "0";
        }
    }
}

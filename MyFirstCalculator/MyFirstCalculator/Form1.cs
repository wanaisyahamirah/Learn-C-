using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(input1.Text);
            double num2 = Convert.ToDouble(input2.Text);

            double sum = num1 + num2;

            result.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(input1.Text);
            double num2 = Convert.ToDouble(input2.Text);

            double difference = num1 - num2;

            result.Text = difference.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(input1.Text);
            double num2 = Convert.ToDouble(input2.Text);

            double multiply = num1 * num2;

            result.Text = multiply.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(input1.Text);
            double num2 = Convert.ToDouble(input2.Text);

            if (num1 !=0 && num2!=0)
            {

                double divide = num1 / num2;
                result.Text = divide.ToString();
            }
            else {
                result.Text = "division by zero.";
            }                        
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double sum = num1 + num2;
            textBox3.Text = sum.ToString();
        }

        public static double Summation(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double difference = num1 - num2;
            textBox3.Text = difference.ToString();
        }

        public static double Difference(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double multiplication = num1 * num2;
            textBox3.Text = multiplication.ToString();
        }

        public static double Multiplication(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double quotient = 0.0;
            quotient = num1 / num2;

            if(num2 != 0 && num1 !=0)
            {
                textBox3.Text = quotient.ToString();
            }
            else
            {
                String message = "Division by zero.";
                textBox3.Text = message;

            }
        }

        public static double Division(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }
    }
}

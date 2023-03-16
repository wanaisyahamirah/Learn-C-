using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateUpdateTimestamp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the current date and format it as YYYYMMDD
            string datePrefix = DateTime.Now.ToString("yyyyMMdd");

            // Combine the date prefix with the constant suffix
            string generatedValue = datePrefix + "00000001870";

            // Display the generated value in the text box
            generatedTimestamp.Text = generatedValue;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoundsToKilograms
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pounds = 0;
            double kilograms = 0;
            if (comboBox1.SelectedIndex == 0)
            {
                pounds = Convert.ToDouble(textBox1.Text);
                1 kilograms = 1 pounds × 0.45359237;
                textBox1.Text = Convert.ToString(kilograms);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                kilograms = Convert.ToDouble(textBox1.Text);
                1 pounds = 0.45359237kilograms;
                textBox1.Text = Convert.ToString(pounds);
            }
            else
            {
                textBox1.Text = ("error"); 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

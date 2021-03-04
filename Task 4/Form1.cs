using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weight = 0;
            double height = 0;
            double BMI = 0;
            weight = Convert.ToDouble(textBox1.Text);
            height = Convert.ToDouble(textBox2.Text);
            BMI = weight / (height * height);
            textBox3.Text = Convert.ToString(BMI); 
        }
    }
}

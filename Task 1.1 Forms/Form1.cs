using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1._1_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double S;
            int b = Convert.ToInt32(textBox1.Text);
            
            int q = Convert.ToInt32(textBox2.Text);
            
            int a = Convert.ToInt32(textBox3.Text);

            S = (b * (Math.Pow(q, a) - b)) / (q - b);

            textBox4.Text = S.ToString();
        }
    }
}

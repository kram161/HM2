using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HM2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AntennaQuality An = new AntennaQuality(textBox1.Text, Convert.ToInt32(numericUpDown1.Value), textBox2.Text, Convert.ToInt32(numericUpDown2.Value));
            double Q = An.Quality();
            label1.Text = Convert.ToString(Q);
            label1.Visible = true;
            label8.Text = textBox2.Text;
            label8.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

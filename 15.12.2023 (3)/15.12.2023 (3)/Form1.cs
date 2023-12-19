using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15._12._2023__3_
{
    public partial class Form1 : Form
    {
        int x = 0, result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToInt32(textBox1.Text);
            }

            catch (Exception b)
            {
                label9.Text=b.Message;

            }
                result = x + 10;
                textBox1.Text = result.ToString();
            

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            result = x - 1000;
            textBox1.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            result = x - 10000;
            textBox1.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            result = x + 1000;
            textBox1.Text = result.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            result = x + 10000;
            textBox1.Text = result.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            result = x = 0;
            textBox1.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x=Convert.ToInt32(textBox1.Text);
            result = x - 10;
            textBox1.Text = result.ToString();
        }
    }
}

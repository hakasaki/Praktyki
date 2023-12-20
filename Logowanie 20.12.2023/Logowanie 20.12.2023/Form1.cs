using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logowanie_20._12._2023
{
    public partial class Form1 : Form
    {
        String Imie ="Marcel";
        public Form1()
        {
            InitializeComponent();
        }
        private void RoundFormCorners(Form form, int radius)
        {
           
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(form.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(form.Width - radius, form.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, form.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            form.Region = new Region(path);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="Admin" && textBox2.Text == "123")
            {
                MessageBox.Show("Prawidłowe Zalogowanie się");
            }
            else
            {
                    MessageBox.Show("Nie prawidłowa Nazwa Użytkownika lub hasło");
            }
        }
    }
}

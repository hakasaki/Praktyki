using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker_19._12._2023
{
    public partial class Form1 : Form
    {
        int wynik = 0,upgrade = 1, upgrade2 = 2;
        public Form1()
        {
            InitializeComponent();
            label2.Text = wynik.ToString();
        }
        public void Usun10OdWyniku(object sender, EventArgs e)
        {
            wynik--;
            wynik--;
            wynik--;
            wynik--;
            wynik--;
            wynik--;
            wynik--;
            wynik--;
            wynik--;
            wynik--;
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            if(upgrade == 1)
            {
                wynik++;
                label2.Text = wynik.ToString();
            }

            if (upgrade == 2)
            {
                wynik++;
                wynik++;
                label2.Text = wynik.ToString();
            }

            if (upgrade == 3)
            {
                wynik++;
                wynik++;
                wynik++;
                label2.Text = wynik.ToString();
            }

        }

      
        
        
        
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if(upgrade == 1 && wynik >= 15)
            {

                Usun10OdWyniku(sender, e);

                wynik--;
                wynik--;
                wynik--;
                wynik--;
                wynik--;

                upgrade++;
                button1.Text = "+3 wynikow za klikniecie / koszt 50 wynikow";  
                label2.Text = wynik.ToString();
            }
            if(upgrade == 2 && wynik >= 50)
            {
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);

                upgrade++;
                button1.Text = "Max lvl";
                label2.Text = wynik.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if(timer1.Interval == 1000)
            {
                wynik++;
            label2.Text = wynik.ToString();
                
            }
            if(timer1.Interval == 200)
            {
                wynik++;
                wynik++;
                wynik++;
                wynik++;
                wynik++;
                label2.Text = wynik.ToString();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        } 
        private void button2_Click(object sender, EventArgs e)
        {
            if(upgrade2 == 1 && wynik >= 75)
            {
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                wynik++;
                wynik++;
                wynik++;
                wynik++;
                wynik++;
                //
                upgrade2++; 
                button2.Text = "5 wynikow na seknude / koszt 250 wynikow";
                label2.Text = wynik.ToString();
                timer1.Start();
            }
            if(upgrade2 == 2 && wynik >= 250)
            {
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                Usun10OdWyniku(sender, e);
                upgrade2++;
                button2.Text = "Max lvl";
                label2.Text = wynik.ToString();
                timer1.Interval = 200;
            }
        }
    }
}

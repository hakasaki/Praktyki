using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15._12._2023__4_
{


                // Funkcje nie są użyte gdyż do każdej zmiennej jest podpiety inny
                // checkbox i by tylko komplikowalo kod lecz powoduje to nadmiar 
                // zbędnego kodu którego nie za bardzo umiem zmniejszyć 



    public partial class Form1 : Form
    {

       
        // int x odpowiada za przedmiott i ocene , nr i nra odpowida za numerki ucznia
        int x = 0, result = 0,przedmiot=0,nr=0,nra = 0;
        public Form1()
        {
            InitializeComponent();
        }



        // Kod odpowiadający za dane do wyboru osob w sposob numerków od 1 - 22


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

         String Imie = "Karol Sibiak";
            String Klasa = "3TF";
            String nr = "1";
            
            textBox1.Text = nra.ToString(nr);
            textBox4.Text = Imie;
            textBox14.Text = Klasa;
            textBox15.Text = nr;
        }
        

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            String Imie = "Jakub Rudczuk";
            String Klasa = "3TF";
            String nr = "2";

            textBox1.Text = nra.ToString(nr);
            textBox4.Text = Imie;
            textBox14.Text = Klasa;
            textBox15.Text = nr;
      
        }


        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            String Imie = "Blazej Kubiak";
            String Klasa = "3TF";
            String nr = "3";

            textBox1.Text = nra.ToString(nr);
            textBox4.Text = Imie;
            textBox14.Text = Klasa;
            textBox15.Text = nr;
        
        }


        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            String Imie = "Adrian Kozłowski";
            String Klasa = "3TF";
            String nr = "4";

            textBox1.Text = nra.ToString(nr);
            textBox4.Text = Imie;
            textBox14.Text = Klasa;
            textBox15.Text = nr;
       
        }


        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

            String Imie = "Bartłomiej Kowalewski";
            String Klasa = "3TF";
            String nr = "5";

            textBox1.Text = nra.ToString(nr);
            textBox4.Text = Imie;
            textBox14.Text = Klasa;
            textBox15.Text = nr;
        
        }

        

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

            String Imie = "Michał Księżopolski";
            String Klasa = "3TF";
            String nr = "6";

            textBox1.Text = nra.ToString(nr);
            textBox4.Text = Imie;
            textBox14.Text = Klasa;
            textBox15.Text = nr;
        
        }


        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
           
            String Imie = "Kuba Wójcik";
            String Klasa = "3TF";
            String nr = "7";

            textBox1.Text = nra.ToString(nr);
            textBox4.Text = Imie;
            textBox14.Text = Klasa;
            textBox15.Text = nr;
       
        }


        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

            String Imie = "Aleks Kozak";
            String Klasa = "3TF";
            String nr = "8";

            textBox1.Text = nra.ToString(nr);
            textBox4.Text = Imie;
            textBox14.Text = Klasa;
            textBox15.Text = nr;
       
        }


        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

            String Imie = "Huber Mściwójewski";
            String Klasa = "3TF";
            String nr = "9";

            textBox1.Text = nra.ToString(nr);
            textBox4.Text = Imie;
            textBox14.Text = Klasa;
            textBox15.Text = nr;
       
        }


        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

            String Imie = "Karol Nowak";
            String Klasa = "3TF";
            String nr = "10";

            textBox1.Text = nra.ToString(nr);
            textBox4.Text = Imie;
            textBox14.Text = Klasa;
            textBox15.Text = nr;
        
        }


        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {

            String Imie = "Maksymilian Wysocki";
            String Klasa = "3TF";
            String nr = "11";

            textBox1.Text = nra.ToString(nr);
            textBox4.Text = Imie;
            textBox14.Text = Klasa;
            textBox15.Text = nr;
        
        }


        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            
            String Imie = "Michał Baron";
            String Klasa = "3TF";
            String nr = "12";

            textBox1.Text = nra.ToString(nr);
            textBox4.Text = Imie;
            textBox14.Text = Klasa;
            textBox15.Text = nr;
       
        }


        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            
            String Imie = "Patryk Czopór";
            String Klasa = "3TF";
            String nr = "13";

            textBox1.Text = nra.ToString(nr);
            textBox4.Text = Imie;
            textBox14.Text = Klasa;
            textBox15.Text = nr;
       
        }


        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
           
            String Imie = "Antek Kibal";
            String Klasa = "3TF";
            String nr = "14";

            textBox1.Text = nra.ToString(nr);
            textBox4.Text = Imie;
            textBox14.Text = Klasa;
            textBox15.Text = nr;
       
        }


        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

            String Imie = "Marcel Jaworski";
            String Klasa = "3TF";
            String nr = "15";

            textBox1.Text = nra.ToString(nr);
            textBox4.Text = Imie;
            textBox14.Text = Klasa;
            textBox15.Text = nr;
       
        }


        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

            String Imie = "Bartek Strzeczlczak";
            String Klasa = "3TF";
            String nr = "16";

            textBox1.Text = nra.ToString(nr);
            textBox4.Text = Imie;
            textBox14.Text = Klasa;
            textBox15.Text = nr;
      
        }


        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

            String Imie = "Bartosz Lemieszko";
            String Klasa = "3TF";
            String nr = "17";

            textBox1.Text = nra.ToString(nr);
            textBox4.Text = Imie;
            textBox14.Text = Klasa;
            textBox15.Text = nr;
      
        }


        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {

            String Imie = "Marceli Koziol";
            String Klasa = "3TF";
            String nr = "18";

            textBox1.Text = nra.ToString(nr);
            textBox4.Text = Imie;
            textBox14.Text = Klasa;
            textBox15.Text = nr;
        
        }


        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {

            String Imie = "Kamil Podgórny";
            String Klasa = "3TF";
            String nr = "19";

            textBox1.Text = nra.ToString(nr);
            textBox4.Text = Imie;
            textBox14.Text = Klasa;
            textBox15.Text = nr;
       
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {

            String Imie = "Grzegorz Maciejewski";
            String Klasa = "3TF";
            String nr = "20";

            textBox1.Text = nra.ToString(nr);
            textBox4.Text = Imie;
            textBox14.Text = Klasa;
            textBox15.Text = nr;
       
        }


        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {

            String Imie = "Kornel Hassa";
            String Klasa = "3TF";
            String nr = "21";

            textBox1.Text = nra.ToString(nr);
            textBox4.Text = Imie;
            textBox14.Text = Klasa;
            textBox15.Text = nr;
       
        }


        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {

            String Imie = "Marcel Michniewicz";
            String Klasa = "3TF";
            String nr = "22";

            textBox1.Text = nra.ToString(nr);
            textBox4.Text = Imie;
            textBox14.Text = Klasa;
            textBox15.Text = nr;
      
        }
        
        

            // Kod odpowiadający za wybierania ocen


        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
         
            x = Convert.ToInt32(textBox3.Text);
            result = x = 6;
            textBox3.Text = result.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            x = Convert.ToInt32(textBox3.Text);
            result = x = 0;
            textBox3.Text = result.ToString();
      
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
         
            x = Convert.ToInt32(textBox3.Text);
            result = x = 5;
            textBox3.Text = result.ToString();
      
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {

            x = Convert.ToInt32(textBox3.Text);
            result = x = 4;
            textBox3.Text = result.ToString();
       
        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {

            x = Convert.ToInt32(textBox3.Text);
            result = x = 3;
            textBox3.Text = result.ToString();
      
        }

        private void checkBox37_CheckedChanged(object sender, EventArgs e)
        {
           
            x = Convert.ToInt32(textBox3.Text);
            result = x = 2;
            textBox3.Text = result.ToString();
       
        }

        private void checkBox38_CheckedChanged(object sender, EventArgs e)
        {
          
            x = Convert.ToInt32(textBox3.Text);
            result = x = 1;
            textBox3.Text = result.ToString();
       
        }

        private void checkBox40_CheckedChanged(object sender, EventArgs e)
        {
          
            x = Convert.ToInt32(textBox3.Text);
            result = x = 5;
            textBox3.Text = result.ToString("+"+x);
       
        }

        private void checkBox41_CheckedChanged(object sender, EventArgs e)
        {
           
            x = Convert.ToInt32(textBox3.Text);
            result = x = 4;
            textBox3.Text = result.ToString("+" + x);
       
        }

        private void checkBox42_CheckedChanged(object sender, EventArgs e)
        {

            x = Convert.ToInt32(textBox3.Text);
            result = x = 3;
            textBox3.Text = result.ToString("+" + x);
       
        }

        private void checkBox43_CheckedChanged(object sender, EventArgs e)
        {

            x = Convert.ToInt32(textBox3.Text);
            result = x = 2;
            textBox3.Text = result.ToString("+" + x);
        
        }

        private void checkBox44_CheckedChanged(object sender, EventArgs e)
        {

            x = Convert.ToInt32(textBox3.Text);
            result = x = 1;
            textBox3.Text = result.ToString("+" + x);
       
        }

        private void checkBox50_CheckedChanged(object sender, EventArgs e)
        {
           
            x = Convert.ToInt32(textBox3.Text);
            result = x = 6;
            textBox3.Text = result.ToString("-" + x);
       
        }

        private void checkBox49_CheckedChanged(object sender, EventArgs e)
        {
           
            x = Convert.ToInt32(textBox3.Text);
            result = x = 5;
            textBox3.Text = result.ToString("-" + x);
       
        }

        private void checkBox48_CheckedChanged(object sender, EventArgs e)
        {
           
            x = Convert.ToInt32(textBox3.Text);
            result = x = 4;
            textBox3.Text = result.ToString("-" + x);
       
        }

        private void checkBox47_CheckedChanged(object sender, EventArgs e)
        {
           
            x = Convert.ToInt32(textBox3.Text);
            result = x = 3;
            textBox3.Text = result.ToString("-" + x);
       
        }

        private void checkBox46_CheckedChanged(object sender, EventArgs e)
        {
          
            x = Convert.ToInt32(textBox3.Text);
            result = x = 2;
            textBox3.Text = result.ToString("-" + x);
     
        }

        private void checkBox45_CheckedChanged(object sender, EventArgs e)
        {
           
            x = Convert.ToInt32(textBox3.Text);
            result = x = 1;
            textBox3.Text = result.ToString("-" + x);
       
        }



        // Wybieranie Przedmiotu i Częściowo błedny kod do dodawania osobie ocen z przedmiotu


        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {


            result = przedmiot = 0;
            textBox2.Text = result.ToString("Matematyka");
            
            // zmienne ocen
            String ocena6 = "6", ocena5 = "5", ocena4 = "4",
                   ocena3 = "3", ocena2 = "2", ocena1 = "1",
                   ocenaa = "+5", ocenab = "+4", ocenac = "+3",
                   ocenad = "+2", ocenae = "+1",ocenaA = "-6",ocenX = "-5", ocenaB = "-4", ocenaC = "-3",
                   ocenaD = "-2", ocenaE = "-1" ;
            


            // ify zadeklarowane ze musiy byc zaznaczony numerek ucznia 
            if(checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox3.Checked == true|| 
               checkBox4.Checked == true || checkBox5.Checked == true || checkBox6.Checked == true || checkBox7.Checked == true ||
               checkBox8.Checked == true || checkBox9.Checked == true || checkBox10.Checked == true || checkBox11.Checked == true || 
               checkBox13.Checked == true || checkBox14.Checked == true || checkBox15.Checked == true || checkBox16.Checked == true|| 
               checkBox17.Checked == true || checkBox18.Checked == true || checkBox19.Checked == true ||checkBox12.Checked == true ||
               checkBox20.Checked == true || checkBox21.Checked == true || checkBox22.Checked != true)
            {
                if (checkBox23.Checked == true)
                {
                    if (checkBox33.Checked)
                    {
                        textBox5.Text += result.ToString(" ," + ocena6);
                    }
                }

                 if (checkBox23.Checked == true)
                 {
                    if (checkBox34.Checked)
                    {
                    textBox5.Text += result.ToString(" ," + ocena5);
                    }
                }

                if (checkBox23.Checked == true)
                {
                    if (checkBox35.Checked)
                    {
                    textBox5.Text += result.ToString(" ," + ocena4);
                    }
                }


                if (checkBox23.Checked == true)
                {
                    if (checkBox36.Checked)
                    {
                    textBox5.Text += result.ToString(" ," + ocena3);
                    }
                }
            
                if (checkBox23.Checked == true)
                {
                    if (checkBox37.Checked)
                    {
                    textBox5.Text += result.ToString(" ," + ocena2);
                    }
                }
            
                if (checkBox23.Checked == true)
                {
                    if (checkBox38.Checked)
                    {
                    textBox5.Text += result.ToString(" ," + ocena1);
                    }
                    if (checkBox40.Checked == true)
                    {
                        textBox5.Text += result.ToString(" ," + ocenaa);
                    }

                    if (checkBox41.Checked == true)
                    {
                        textBox5.Text += result.ToString(" ," + ocenab);

                    }
                    if (checkBox42.Checked == true)
                    {
                        textBox5.Text += result.ToString(" ," + ocenac);
                    }
                    if (checkBox43.Checked == true)
                    {
                        textBox5.Text += result.ToString(" ," + ocenad);
                    }
                    if (checkBox44.Checked == true)
                    {
                        textBox5.Text += result.ToString(" ," + ocenae);
                    }

                    if (checkBox50.Checked == true)
                    {
                        textBox5.Text += result.ToString(" ," + ocenaA);
                    }
                    if (checkBox49.Checked == true)
                    {
                        textBox5.Text += result.ToString(" ," + ocenX);
                    }
                    if (checkBox48.Checked == true)
                    {
                        textBox5.Text += result.ToString(" ," + ocenaB);
                    }
                    if (checkBox47.Checked == true)
                    {
                        textBox5.Text += result.ToString(" ," + ocenaC);
                    }
                    if (checkBox46.Checked == true)
                    {
                        textBox5.Text += result.ToString(" ," + ocenaD);
                    }
                    if (checkBox45.Checked == true)
                    {
                        textBox5.Text += result.ToString(" ," + ocenaE);
                    }



            }
        }
        else
        {

    }
        
}
      
        private void checkBox24_CheckedChanged_1(object sender, EventArgs e)
        {
            result = przedmiot = 0;
            textBox2.Text = result.ToString("Język Angielski");
            String ocena6 = "6", ocena5 = "5", ocena4 = "4",
                   ocena3 = "3", ocena2 = "2", ocena1 = "1",
                   ocenaa = "+5", ocenab = "+4", ocenac = "+3",
                   ocenad = "+2", ocenae = "+1", ocenaA = "-6",
                   ocenX = "-5", ocenaB = "-4", ocenaC = "-3",
                   ocenaD = "-2", ocenaE = "-1";
            


            if (checkBox24.Checked == true)
            {

           

            if    (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox3.Checked == true ||
                  checkBox4.Checked == true || checkBox5.Checked == true || checkBox6.Checked == true || checkBox7.Checked == true ||
                  checkBox8.Checked == true || checkBox9.Checked == true || checkBox10.Checked == true || checkBox11.Checked == true || 
                  checkBox13.Checked == true || checkBox14.Checked == true || checkBox15.Checked == true || checkBox16.Checked|| 
                  checkBox17.Checked == true || checkBox18.Checked == true || checkBox19.Checked == true ||checkBox12.Checked == true ||
                  checkBox20.Checked == true || checkBox21.Checked == true || checkBox22.Checked != true)
                {

                if (checkBox33.Checked)
                {
                    textBox6.Text += result.ToString(" ," + ocena6);
                }

                if (checkBox34.Checked)
                {
                    textBox6.Text += result.ToString(" ," + ocena5);
                }


                if (checkBox35.Checked)
                {
                    textBox6.Text += result.ToString(" ," + ocena4);
                }

                if (checkBox36.Checked)
                {
                    textBox6.Text += result.ToString(" ," + ocena3);
                }

                if (checkBox37.Checked)
                {
                    textBox6.Text += result.ToString(" ," + ocena2);
                }

                if (checkBox38.Checked)
                {
                    textBox6.Text += result.ToString(" ," + ocena1);
                }
                    if (checkBox40.Checked == true)
                    {
                        textBox6.Text += result.ToString(" ," + ocenaa);
                    }

                    if (checkBox41.Checked == true)
                    {
                        textBox6.Text += result.ToString(" ," + ocenab);

                    }

                    if (checkBox42.Checked == true)
                    {
                        textBox6.Text += result.ToString(" ," + ocenac);
                    }

                    if (checkBox43.Checked == true)
                    {
                        textBox6.Text += result.ToString(" ," + ocenad);
                    }

                    if (checkBox44.Checked == true)
                    {
                        textBox6.Text += result.ToString(" ," + ocenae);
                    }

                    if (checkBox50.Checked == true)
                    {
                        textBox6.Text += result.ToString(" ," + ocenaA);
                    }

                    if (checkBox49.Checked == true)
                    {
                        textBox6.Text += result.ToString(" ," + ocenX);
                    }

                    if (checkBox48.Checked == true)
                    {
                        textBox6.Text += result.ToString(" ," + ocenaB);
                    }

                    if (checkBox47.Checked == true)
                    {
                        textBox6.Text += result.ToString(" ," + ocenaC);
                    }

                    if (checkBox46.Checked == true)
                    {
                        textBox6.Text += result.ToString(" ," + ocenaD);
                    }

                    if (checkBox45.Checked == true)
                    {
                        textBox6.Text += result.ToString(" ," + ocenaE);
                    }

            }
            else
            {

        }
    }
}

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            result = przedmiot = 0;
            textBox2.Text = result.ToString("Język Niemiecki");
            String ocena6 = "6", ocena5 = "5", ocena4 = "4",
                   ocena3 = "3", ocena2 = "2", ocena1 = "1",
                   ocenaa = "+5", ocenab = "+4", ocenac = "+3",
                   ocenad = "+2", ocenae = "+1", ocenaA = "-6",
                   ocenX = "-5", ocenaB = "-4", ocenaC = "-3",
                   ocenaD = "-2", ocenaE = "-1";
            


            if (checkBox26.Checked == true)
            {

            

                 if(checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox3.Checked == true||
                   checkBox4.Checked == true || checkBox5.Checked == true || checkBox6.Checked == true || checkBox7.Checked == true ||
                   checkBox8.Checked == true || checkBox9.Checked == true || checkBox10.Checked == true || checkBox11.Checked == true || checkBox12.Checked == true ||
                   checkBox13.Checked == true || checkBox14.Checked == true || checkBox15.Checked == true || checkBox16.Checked == true|| 
                   checkBox17.Checked == true || checkBox18.Checked == true || checkBox19.Checked == true ||
                   checkBox20.Checked == true || checkBox21.Checked == true || checkBox22.Checked != true)
                {

                if (checkBox33.Checked)
                {
                    textBox8.Text += result.ToString(" ," + ocena6);
                }

                if (checkBox34.Checked)
                {
                    textBox8.Text += result.ToString(" ," + ocena5);
                }


                if (checkBox35.Checked)
                {
                    textBox8.Text += result.ToString(" ," + ocena4);
                }

                if (checkBox36.Checked)
                {
                    textBox8.Text += result.ToString(" ," + ocena3);
                }

                if (checkBox37.Checked)
                {
                    textBox8.Text += result.ToString(" ," + ocena2);
                }

                if (checkBox38.Checked)
                {
                    textBox8.Text += result.ToString(" ," + ocena1);
                }

               if (checkBox40.Checked == true)
                {
                    textBox8.Text += result.ToString(" ," + ocenaa);
                }

               if (checkBox41.Checked == true)
                {
                    textBox8.Text += result.ToString(" ," + ocenab);

                }

               if (checkBox42.Checked == true)
                    {
                    textBox8.Text += result.ToString(" ," + ocenac);
                    }
                   
               if (checkBox43.Checked == true)
                    {
                    textBox8.Text += result.ToString(" ," + ocenad);
                    }

               if (checkBox44.Checked == true)
                    {
                    textBox8.Text += result.ToString(" ," + ocenae);
                    }

               if (checkBox50.Checked == true)
                    {
                    textBox8.Text += result.ToString(" ," + ocenaA);
                    }

               if (checkBox49.Checked == true)
                    {
                    textBox8.Text += result.ToString(" ," + ocenX);
                    }

               if (checkBox48.Checked == true)
                    {
                    textBox8.Text += result.ToString(" ," + ocenaB);
                    }

               if (checkBox47.Checked == true)
                    {
                    textBox8.Text += result.ToString(" ," + ocenaC);
                    }

               if (checkBox46.Checked == true)
                    {
                    textBox8.Text += result.ToString(" ," + ocenaD);
                    }

               if (checkBox45.Checked == true)
                    {
                    textBox8.Text += result.ToString(" ," + ocenaE);
                    }

            }
         else
            {
        }
    }
}

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            result = przedmiot = 0;
            textBox2.Text = result.ToString("Informatyka");
            String ocena6 = "6", ocena5 = "5", ocena4 = "4",
                   ocena3 = "3", ocena2 = "2", ocena1 = "1",
                   ocenaa = "+5", ocenab = "+4", ocenac = "+3",
                   ocenad = "+2", ocenae = "+1", ocenaA = "-6",
                   ocenX = "-5", ocenaB = "-4", ocenaC = "-3",
                   ocenaD = "-2", ocenaE = "-1";
            


            if (checkBox27.Checked == true)
            {

            

                 if(checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox3.Checked == true ||
                   checkBox4.Checked == true || checkBox5.Checked == true || checkBox6.Checked == true || checkBox7.Checked == true ||
                   checkBox8.Checked == true || checkBox9.Checked == true || checkBox10.Checked == true || checkBox11.Checked == true || checkBox12.Checked == true ||
                   checkBox13.Checked == true || checkBox14.Checked == true || checkBox15.Checked == true || checkBox16.Checked||
                   checkBox17.Checked == true || checkBox18.Checked == true || checkBox19.Checked == true ||
                   checkBox20.Checked == true || checkBox21.Checked == true || checkBox22.Checked != true)
                {

                if (checkBox33.Checked)
                {
                    textBox9.Text += result.ToString(" ," + ocena6);
                }

                if (checkBox34.Checked)
                {
                    textBox9.Text += result.ToString(" ," + ocena5);
                }


                if (checkBox35.Checked)
                {
                    textBox9.Text += result.ToString(" ," + ocena4);
                }

                if (checkBox36.Checked)
                {
                    textBox9.Text += result.ToString(" ," + ocena3);
                }

                if (checkBox37.Checked)
                {
                    textBox9.Text += result.ToString(" ," + ocena2);
                }


                if (checkBox38.Checked)
                {
                    textBox9.Text += result.ToString(" ," + ocena1);
                }
                
                if (checkBox40.Checked == true)
                    {
                        textBox9.Text += result.ToString(" ," + ocenaa);
                    }

                    if (checkBox41.Checked == true)
                    {
                        textBox9.Text += result.ToString(" ," + ocenab);

                    }
                    if (checkBox42.Checked == true)
                    {
                        textBox9.Text += result.ToString(" ," + ocenac);
                    }
                    if (checkBox43.Checked == true)
                    {
                        textBox9.Text += result.ToString(" ," + ocenad);
                    }
                    if (checkBox44.Checked == true)
                    {
                        textBox9.Text += result.ToString(" ," + ocenae);
                    }
                    if (checkBox50.Checked == true)
                    {
                        textBox9.Text += result.ToString(" ," + ocenaA);
                    }
                    if (checkBox49.Checked == true)
                    {
                        textBox9.Text += result.ToString(" ," + ocenX);
                    }
                    if (checkBox48.Checked == true)
                    {
                        textBox9.Text += result.ToString(" ," + ocenaB);
                    }
                    if (checkBox47.Checked == true)
                    {
                        textBox9.Text += result.ToString(" ," + ocenaC);
                    }
                    if (checkBox46.Checked == true)
                    {
                        textBox9.Text += result.ToString(" ," + ocenaD);
                    }
                    if (checkBox45.Checked == true)
                    {
                        textBox9.Text += result.ToString(" ," + ocenaE);
                    }

                }
            else
            {

            }}
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            result = przedmiot = 0;
            textBox2.Text = result.ToString("Chemia");
          
             String ocena6 = "6", ocena5 = "5", ocena4 = "4",
                    ocena3 = "3", ocena2 = "2", ocena1 = "1",
                    ocenaa = "+5", ocenab = "+4", ocenac = "+3",
                    ocenad = "+2", ocenae = "+1", ocenaA = "-6", 
                    ocenX = "-5", ocenaB = "-4", ocenaC = "-3",
                    ocenaD = "-2", ocenaE = "-1";
            ;


            if (checkBox28.Checked == true)
            {

           

            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox3.Checked == true
                   || checkBox4.Checked == true || checkBox5.Checked == true || checkBox6.Checked == true || checkBox7.Checked == true ||
                   checkBox8.Checked == true || checkBox9.Checked == true || checkBox10.Checked == true || checkBox11.Checked == true || checkBox12.Checked == true ||
                   checkBox13.Checked == true || checkBox14.Checked == true || checkBox15.Checked == true || checkBox16.Checked
                   || checkBox17.Checked == true || checkBox18.Checked == true || checkBox19.Checked == true ||
                   checkBox20.Checked == true || checkBox21.Checked == true || checkBox22.Checked != true)
                {
                if (checkBox33.Checked)
                {
                    textBox10.Text += result.ToString(" ," + ocena6);
                }

                if (checkBox34.Checked)
                {
                    textBox10.Text += result.ToString(" ," + ocena5);
                }


                if (checkBox35.Checked)
                {
                    textBox10.Text += result.ToString(" ," + ocena4);
                }

                if (checkBox36.Checked)
                {
                    textBox10.Text += result.ToString(" ," + ocena3);
                }

                if (checkBox37.Checked)
                {
                    textBox10.Text += result.ToString(" ," + ocena2);
                }


                if (checkBox38.Checked)
                {
                    textBox10.Text += result.ToString(" ," + ocena1);
                }
                    if (checkBox40.Checked == true)
                    {
                        textBox10.Text += result.ToString(" ," + ocenaa);
                    }

                    if (checkBox41.Checked == true)
                    {
                        textBox10.Text += result.ToString(" ," + ocenab);

                    }
                    if (checkBox42.Checked == true)
                    {
                        textBox10.Text += result.ToString(" ," + ocenac);
                    }
                    if (checkBox43.Checked == true)
                    {
                        textBox10.Text += result.ToString(" ," + ocenad);
                    }
                    if (checkBox44.Checked == true)
                    {
                        textBox10.Text += result.ToString(" ," + ocenae);
                    }
                    if (checkBox50.Checked == true)
                    {
                        textBox10.Text += result.ToString(" ," + ocenaA);
                    }
                    if (checkBox49.Checked == true)
                    {
                        textBox10.Text += result.ToString(" ," + ocenX);
                    }
                    if (checkBox48.Checked == true)
                    {
                        textBox10.Text += result.ToString(" ," + ocenaB);
                    }
                    if (checkBox47.Checked == true)
                    {
                        textBox10.Text += result.ToString(" ," + ocenaC);
                    }
                    if (checkBox46.Checked == true)
                    {
                        textBox10.Text += result.ToString(" ," + ocenaD);
                    }
                    if (checkBox45.Checked == true)
                    {
                        textBox10.Text += result.ToString(" ," + ocenaE);
                    }

                }
            else
            {

            } }
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            result = przedmiot = 0;
            textBox2.Text = result.ToString("Fizyka");
        String ocena6 = "6", ocena5 = "5", ocena4 = "4",
               ocena3 = "3", ocena2 = "2", ocena1 = "1",
               ocenaa = "+5", ocenab = "+4", ocenac = "+3",
               ocenad = "+2", ocenae = "+1", ocenaA = "-6",
               ocenX = "-5", ocenaB = "-4", ocenaC = "-3",
               ocenaD = "-2", ocenaE = "-1";
            ;


            if (checkBox29.Checked == true)
            {

            
                
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox3.Checked == true
                   || checkBox4.Checked == true || checkBox5.Checked == true || checkBox6.Checked == true || checkBox7.Checked == true ||
                   checkBox8.Checked == true || checkBox9.Checked == true || checkBox10.Checked == true || checkBox11.Checked == true || checkBox12.Checked == true ||
                   checkBox13.Checked == true || checkBox14.Checked == true || checkBox15.Checked == true || checkBox16.Checked
                   || checkBox17.Checked == true || checkBox18.Checked == true || checkBox19.Checked == true ||
                   checkBox20.Checked == true || checkBox21.Checked == true || checkBox22.Checked != true)
                {
                if (checkBox33.Checked)
                {
                    textBox11.Text += result.ToString(" ," + ocena6);
                }

                if (checkBox34.Checked)
                {
                    textBox11.Text += result.ToString(" ," + ocena5);
                }


                if (checkBox35.Checked)
                {
                    textBox11.Text += result.ToString(" ," + ocena4);
                }

                if (checkBox36.Checked)
                {
                    textBox11.Text += result.ToString(" ," + ocena3);
                }

                if (checkBox37.Checked)
                {
                    textBox11.Text += result.ToString(" ," + ocena2);
                }


                if (checkBox38.Checked)
                {
                    textBox11.Text += result.ToString(" ," + ocena1);
                }
                    if (checkBox40.Checked == true)
                    {
                        textBox11.Text += result.ToString(" ," + ocenaa);
                    }

                    if (checkBox41.Checked == true)
                    {
                        textBox11.Text += result.ToString(" ," + ocenab);

                    }
                    if (checkBox42.Checked == true)
                    {
                        textBox11.Text += result.ToString(" ," + ocenac);
                    }
                    if (checkBox43.Checked == true)
                    {
                        textBox11.Text += result.ToString(" ," + ocenad);
                    }
                    if (checkBox44.Checked == true)
                    {
                        textBox11.Text += result.ToString(" ," + ocenae);
                    }
                    if (checkBox50.Checked == true)
                    {
                        textBox11.Text += result.ToString(" ," + ocenaA);
                    }
                    if (checkBox49.Checked == true)
                    {
                        textBox11.Text += result.ToString(" ," + ocenX);
                    }
                    if (checkBox48.Checked == true)
                    {
                        textBox11.Text += result.ToString(" ," + ocenaB);
                    }
                    if (checkBox47.Checked == true)
                    {
                        textBox11.Text += result.ToString(" ," + ocenaC);
                    }
                    if (checkBox46.Checked == true)
                    {
                        textBox11.Text += result.ToString(" ," + ocenaD);
                    }
                    if (checkBox45.Checked == true)
                    {
                        textBox11.Text += result.ToString(" ," + ocenaE);
                    }

                }
            else
            {

            }}
        }

      


        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = result.ToString("Język Polski");
            String ocena6 = "6", ocena5 = "5", ocena4 = "4",
              ocena3 = "3", ocena2 = "2", ocena1 = "1",
              ocenaa = "+5",ocenab = "+4",ocenac = "+3",
             ocenad = "+2",ocenae = "+1", ocenaA = "-6", ocenX = "-5", ocenaB = "-4", ocenaC = "-3",
             ocenaD = "-2", ocenaE = "-1";


            if (checkBox25.Checked == true)
            {

            

            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox3.Checked == true
                   || checkBox4.Checked == true || checkBox5.Checked == true || checkBox6.Checked == true || checkBox7.Checked == true ||
                   checkBox8.Checked == true || checkBox9.Checked == true || checkBox10.Checked == true || checkBox11.Checked == true || checkBox12.Checked == true ||
                   checkBox13.Checked == true || checkBox14.Checked == true || checkBox15.Checked == true || checkBox16.Checked
                   || checkBox17.Checked == true || checkBox18.Checked == true || checkBox19.Checked == true ||
                   checkBox20.Checked == true || checkBox21.Checked == true || checkBox22.Checked != true)
                {
                if (checkBox33.Checked)
                {
                    textBox7.Text += result.ToString(" ," + ocena6);
                }

                if (checkBox34.Checked)
                {
                    textBox7.Text += result.ToString(" ," + ocena5);
                }


                if (checkBox35.Checked)
                {
                    textBox7.Text += result.ToString(" ," + ocena4);
                }

                if (checkBox36.Checked)
                {
                    textBox7.Text += result.ToString(" ," + ocena3);
                }

                if (checkBox37.Checked)
                {
                    textBox7.Text += result.ToString(" ," + ocena2);
                }


                if (checkBox38.Checked)
                {
                    textBox7.Text += result.ToString(" ," + ocena1);
                }
                    if (checkBox40.Checked == true)
                    {
                        textBox7.Text += result.ToString(" ," + ocenaa);
                    }

                    if (checkBox41.Checked == true)
                    {
                        textBox7.Text += result.ToString(" ," + ocenab);

                    }
                    if (checkBox42.Checked == true)
                    {
                        textBox7.Text += result.ToString(" ," + ocenac);
                    }
                    if (checkBox43.Checked == true)
                    {
                        textBox7.Text += result.ToString(" ," + ocenad);
                    }
                    if (checkBox44.Checked == true)
                    {
                        textBox7.Text += result.ToString(" ," + ocenae);
                    }
                    if (checkBox50.Checked == true)
                    {
                        textBox7.Text += result.ToString(" ," + ocenaA);
                    }
                    if (checkBox49.Checked == true)
                    {
                        textBox7.Text += result.ToString(" ," + ocenX);
                    }
                    if (checkBox48.Checked == true)
                    {
                        textBox7.Text += result.ToString(" ," + ocenaB);
                    }
                    if (checkBox47.Checked == true)
                    {
                        textBox7.Text += result.ToString(" ," + ocenaC);
                    }
                    if (checkBox46.Checked == true)
                    {
                        textBox7.Text += result.ToString(" ," + ocenaD);
                    }
                    if (checkBox45.Checked == true)
                    {
                        textBox7.Text += result.ToString(" ," + ocenaE);
                    }

                }
            else
            {

            }}
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            result = przedmiot = 0;
            textBox2.Text = result.ToString("Geografia");
            String ocena6 = "6", ocena5 = "5", ocena4 = "4",
             ocena3 = "3", ocena2 = "2", ocena1 = "1", 
             ocenaa = "+5",ocenab = "+4",ocenac = "+3",
             ocenad = "+2",ocenae = "+1", ocenaA = "-6", ocenX = "-5", ocenaB = "-4", ocenaC = "-3",
             ocenaD = "-2", ocenaE = "-1";


            if (checkBox30.Checked == true)
            {

            

            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox3.Checked == true
                   || checkBox4.Checked == true || checkBox5.Checked == true || checkBox6.Checked == true || checkBox7.Checked == true ||
                   checkBox8.Checked == true || checkBox9.Checked == true || checkBox10.Checked == true || checkBox11.Checked == true || checkBox12.Checked == true ||
                   checkBox13.Checked == true || checkBox14.Checked == true || checkBox15.Checked == true || checkBox16.Checked
                   || checkBox17.Checked == true || checkBox18.Checked == true || checkBox19.Checked == true ||
                   checkBox20.Checked == true || checkBox21.Checked == true || checkBox22.Checked != true)
                {
                if (checkBox33.Checked)
                {
                    textBox12.Text += result.ToString(" ," + ocena6);
                }

                if (checkBox34.Checked)
                {
                    textBox12.Text += result.ToString(" ," + ocena5);
                }


                if (checkBox35.Checked)
                {
                    textBox12.Text += result.ToString(" ," + ocena4);
                }

                if (checkBox36.Checked)
                {
                    textBox12.Text += result.ToString(" ," + ocena3);
                }

                if (checkBox37.Checked)
                {
                    textBox12.Text += result.ToString(" ," + ocena2);
                }


                if (checkBox38.Checked)
                {
                    textBox12.Text += result.ToString(" ," + ocena1);
                }
                    if (checkBox40.Checked == true)
                    {
                        textBox12.Text += result.ToString(" ," + ocenaa);
                    }

                    if (checkBox41.Checked == true)
                    {
                        textBox12.Text += result.ToString(" ," + ocenab);

                    }
                    if (checkBox42.Checked == true)
                    {
                        textBox12.Text += result.ToString(" ," + ocenac);
                    }
                    if (checkBox43.Checked == true)
                    {
                        textBox12.Text += result.ToString(" ," + ocenad);
                    }
                    if (checkBox44.Checked == true)
                    {
                        textBox12.Text += result.ToString(" ," + ocenae);
                    }
                    if (checkBox50.Checked == true)
                    {
                        textBox12.Text += result.ToString(" ," + ocenaA);
                    }
                    if (checkBox49.Checked == true)
                    {
                        textBox12.Text += result.ToString(" ," + ocenX);
                    }
                    if (checkBox48.Checked == true)
                    {
                        textBox12.Text += result.ToString(" ," + ocenaB);
                    }
                    if (checkBox47.Checked == true)
                    {
                        textBox12.Text += result.ToString(" ," + ocenaC);
                    }
                    if (checkBox46.Checked == true)
                    {
                        textBox12.Text += result.ToString(" ," + ocenaD);
                    }
                    if (checkBox45.Checked == true)
                    {
                        textBox12.Text += result.ToString(" ," + ocenaE);
                    }

                }
            }
            else
            {

            }
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            result = przedmiot = 0;
            textBox2.Text = result.ToString("Biologia");
            String ocena6 = "6", ocena5 = "5", ocena4 = "4",
             ocena3 = "3", ocena2 = "2", ocena1 = "1",
              ocenaa = "+5", ocenab = "+4", ocenac = "+3",
             ocenad = "+2", ocenae = "+1", ocenaA = "-6", ocenX = "-5", ocenaB = "-4", ocenaC = "-3",
             ocenaD = "-2", ocenaE = "-1";
            ;

            if (checkBox31.Checked == true)
            {

            

            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox3.Checked == true
                   || checkBox4.Checked == true || checkBox5.Checked == true || checkBox6.Checked == true || checkBox7.Checked == true ||
                   checkBox8.Checked == true || checkBox9.Checked == true || checkBox10.Checked == true || checkBox11.Checked == true || checkBox12.Checked == true ||
                   checkBox13.Checked == true || checkBox14.Checked == true || checkBox15.Checked == true || checkBox16.Checked
                   || checkBox17.Checked == true || checkBox18.Checked == true || checkBox19.Checked == true ||
                   checkBox20.Checked == true || checkBox21.Checked == true || checkBox22.Checked != true)
                {
                if (checkBox33.Checked == true)
                {

                    textBox13.Text += result.ToString(" ," + ocena6);
                }

                if (checkBox34.Checked == true)
                {
                    textBox13.Text += result.ToString(" ," + ocena5);
                }


                if (checkBox35.Checked == true)
                {
                    textBox13.Text += result.ToString(" ," + ocena4);
                }

                if (checkBox36.Checked == true)
                {
                    textBox13.Text += result.ToString(" ," + ocena3);
                }

                if (checkBox37.Checked == true)
                {
                    textBox13.Text += result.ToString(" ," + ocena2);
                }


                if (checkBox38.Checked == true)
                {
                    textBox13.Text += result.ToString(" ," + ocena1);
                }

                    if (checkBox40.Checked == true)
                    {
                        textBox13.Text += result.ToString(" ," + ocenaa);
                    }

                    if (checkBox41.Checked == true)
                    {
                        textBox13.Text += result.ToString(" ," + ocenab);

                    }
                    if (checkBox42.Checked == true)
                    {
                        textBox13.Text += result.ToString(" ," + ocenac);
                    }
                    if (checkBox43.Checked == true)
                    {
                        textBox13.Text += result.ToString(" ," + ocenad);
                    }
                    if (checkBox44.Checked == true)
                    {
                        textBox13.Text += result.ToString(" ," + ocenae);
                    }
                    if (checkBox50.Checked == true)
                    {
                        textBox13.Text += result.ToString(" ," + ocenaA);
                    }
                    if (checkBox49.Checked == true)
                    {
                        textBox13.Text += result.ToString(" ," + ocenX);
                    }
                    if (checkBox48.Checked == true)
                    {
                        textBox13.Text += result.ToString(" ," + ocenaB);
                    }
                    if (checkBox47.Checked == true)
                    {
                        textBox13.Text += result.ToString(" ," + ocenaC);
                    }
                    if (checkBox46.Checked == true)
                    {
                        textBox13.Text += result.ToString(" ," + ocenaD);
                    }
                    if (checkBox45.Checked == true)
                    {
                        textBox13.Text += result.ToString(" ," + ocenaE);
                    }

                }
            else
            {

            }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {


            textBox2.Text = result.ToString("Brak");
        }


        //pozostałości kodu do dodania do kodu

private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {


        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
private void label26_Click(object sender, EventArgs e)
        {

        }
private void label6_Click(object sender, EventArgs e)
        {

        }
private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}

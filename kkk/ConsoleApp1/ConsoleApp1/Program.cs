using System;
using System.Diagnostics;
using System.Linq.Expressions;

class Hello

{
    /*   static void Main()
       {
           Console.WriteLine("Wpisz swoje wybrane liczby");

            Console.WriteLine("Podaj pierwsza liczbę: ");

                   float x = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Podaj druga liczbę: ");

                  float y = Convert.ToInt32(Console.ReadLine());


   ---------------------------------------------------------------Kalkulator-------------------------------------------------------------------




           float mnozenie = x * y;
           float dzielenie = x / y;
           float dodawanie = x + y;
           float odejmowanie = x - y;

           Console.WriteLine("Kalkulator : \n");
           Console.WriteLine("Iloczy  = | * |");
           Console.WriteLine("Iloraz  = | / |");
           Console.WriteLine("Suma    = | + |");
           Console.WriteLine("Roznica = | - | \n");

           Console.WriteLine("Wybierz znak : ");
           String symbol = Console.ReadLine();

           switch (symbol) {
               case "*": Console.WriteLine("Wynik : "+mnozenie);
                   break;
               case "/": Console.WriteLine("Wynik : "+dzielenie);
                   break;
               case "+": Console.WriteLine("Wynik : "+dodawanie);
                   break;
               case "-": Console.WriteLine("Wynik : "+odejmowanie);
                   break;
           }       

       } */









    static void Main()
    {
        Console.WriteLine("Prosty kalkulator");

        string input = "";
        double wynik = 0;
                    double operatorr=0;

        while (true)
        {
            Console.Write("Wprowadź liczbę lub działanie (+ , - , * , / , bs - backspace, = - zakończ): ");
            input = Console.ReadLine();

            if (input == "=")
            {
                Console.WriteLine("Wynik: " + wynik);
                break;
            }

          
            
           
                    char operacja = input[0];
                   
                        switch (operacja)
                        {
                            case '+':
                                wynik += operatorr;
                    break;
                            case '-':
                                wynik -= operatorr;
                                break;
                            case '*':
                                wynik *= operatorr;
                                break;
                            case '/':
                                if (operatorr != 0)
                                {
                                    wynik /= operatorr;
                                }
                                else
                                {
                                    Console.WriteLine("Nie można dzielić przez zero.");
                                }
                                break;
                            default:
                               // Console.WriteLine("Nieznane działanie.");
                                break;
                        }
            int n;
                        if(int.TryParse(input, out n)){
                Console.WriteLine("Jesyem liczba");
                operatorr = Convert.ToInt32(input);
            }
            else
            {
                Console.WriteLine("Wprowadzono bledne dane");
            }

                        Console.WriteLine("Aktualne wprowadzenie: " + wynik);
                    }
                    
                }
            
        }
    


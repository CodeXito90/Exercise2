using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2

{
    //Menyval 1 kommer innehålla 2 klasser för alternativ 1 och 2 i huvudymenyn, vi börjar med 
    //val 1
    internal class MenyVal1
    {
        //Val 1 klassen kommer kontrollera om ålder är under 20 eller över 64,
        //samt skriva till konsolen pris för angivna ålder
        public static void Val1() 
        {
            Console.WriteLine("Ange ålder");

            string userAge = Console.ReadLine();
            int age = 0;

            if (int.TryParse(userAge, out age)) 
            {
                if (age <= 5 || age > 100)
                {
                    Console.WriteLine("Grattis inträde!");
                }
                else if (age >= 6 && age < 20)
                {
                    Console.WriteLine("Ungdomspris: 80kr");
                }
                else if (age > 64 && age <= 100)
                {
                    Console.WriteLine("Pensionär pris: 90kr");
                }
                else if (age >= 20 && age <= 63)
                {
                    Console.WriteLine("Standard pris: 120kr");
                }
            }

            else 
            { 
                Console.WriteLine("Felaktig input. Ange en giltig ålder."); 
            
            }
          }

        public static void Val2()
        {
            //Här ska användaren ange hur många personer dem är, vår if statement tar då hand om
            //logiken för hur mycket total kostnaden kommer bli
            Console.WriteLine("Ange antal personer i sällskapet");
            
            string userInput = Console.ReadLine();
            int numberOfPeople;
            int totalCost = 0;

            if (int.TryParse(userInput, out numberOfPeople))
            {
                for (int i = 1; i <= numberOfPeople; i++)
                {
                    Console.Write($"Ange åldern för person {i}: ");
                    string inputAge = Console.ReadLine();
                    int age =0;

                    if (int.TryParse(inputAge, out age))
                    {
                        if (age <= 5 || age > 100)
                        {
                            totalCost += 0; // grattis för barn och 100+ pensionärer
                        }
                        else if (age >= 6 && age < 20)
                        {
                            totalCost += 80; // Ungdomspris
                        }
                        else if (age > 64 && age <= 100)
                        {
                            totalCost += 90; // Pensionärspris
                        }
                        else if (age >= 20 && age <= 63) // Removed the semicolon
                        {
                            totalCost += 120; // Standardpris
                        }
                    }
                    else
                    {
                        Console.WriteLine("Felaktig input. Försök igen.");
                        i--; // Går tillbaka ett steg om input var ogiltig
                    }
                }

                Console.WriteLine($"Totalt antal personer: {numberOfPeople}");
                Console.WriteLine($"Totalkostnad för hela sällskapet: {totalCost}kr");
            }
            else
            {
                Console.WriteLine("Felaktig input. Ange ett giltigt antal personer.");
            }
        }

    }
    }


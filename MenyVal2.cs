using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    //Menyval 2 innehåller klasserna för alternativ 3 och 4 i huvudmenyn,
    //vi börjar med val 3, en public static void metod som kommer upprpepa 10 gånger vad än
    //användaren skriver in 
    internal class MenyVal2
    {        
        public static void Val3()
        {
            Console.WriteLine("Testa skriva nånting");

            string userInput = Console.ReadLine();

            //for loop logiken som upprepar texten tio gånger, vår konsol ska 
            //skriva ut utan radbrytning!
            for (int i = 0; i < 10; i++)
            {
                Console.Write(userInput);
            }

            Console.WriteLine();

        }

        // Metod för det tredje ordet, användaren ska skriva en mening,
        // som programmet delar upp i ord via strängens .Split(char) - metod
        public static void Val4()
        {         

            Console.WriteLine("Skriv nånting minst 3 ord:");

            string userInput = Console.ReadLine();
            string[] words = userInput.Split(' ');

            if (words.Length >= 3)
            {
                Console.WriteLine($"Det tredje ordet är: {words[2]} ");
            }
            //validerar om gilltig input, om det mindre än tre ord så försök igen
            else 
            {
                Console.WriteLine("Mening måste innehålla minst 3 ord.");
            }
        }
    }
}

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // En enkerl keepActive bool variable intiterad som =true,
            // kommer se till att programet körs nonstop tills vi säger till.
            bool KeepActive = true;

            while (KeepActive)
            {
                // Vår huvudmeny 
                Console.WriteLine("Välkommen till huvudmenyn!");
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Ungdom eller pensionär");
                Console.WriteLine("2. Räkna priset för hela sällskapet");
                Console.WriteLine("3. upprepa 10 gånger");
                Console.WriteLine("4. Det tredje ordet");
                Console.WriteLine("0. Avlsuta");

                string userSelection = Console.ReadLine();

                // Switch statement som kommer ta hand om all user input, metoderna för menyval1 och 2
                // är skapade i 2 olika klass filer, 
                switch (userSelection)
                {
                    case "0":
                        KeepActive = false;
                        Console.WriteLine("Programet avslutas");
                        break;
                    case "1":
                        MenyVal1.Val1();
                        break;
                    case "2":
                        MenyVal1.Val2();
                        break;
                    case "3":
                        MenyVal2.Val3();
                        break;
                    case "4":
                        MenyVal2.Val4();
                        break;
                    default:
                        //Validerar om input är fél eller inte
                        Console.WriteLine("Felaktig input. Försök igen.");
                        break;
                }

            }
        }
           
    }
}

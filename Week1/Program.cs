using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string naam = "Chun Kit Hon";
            char variabele1 = 'C';
            int nummer1 = 123;
            float nummer2 = 1.5f;
            bool status = false;
            float rest = (nummer1 % nummer2);

                Console.WriteLine("Hello" + " " + naam);
                Console.WriteLine(variabele1 + " " + nummer1);
                Console.WriteLine(nummer2 + " " + status);
                Console.WriteLine(rest);
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Voer aantal celcius in:");
            int temperatuur = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            float F = temperatuur * 1.8f + 32;
                Console.WriteLine("Temperatuur is" + " " + F + " " + "Fahrenheit");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Euro naar Dollar:");
            double euro = Convert.ToDouble(Console.ReadLine()); // Doubles ipv floats. Floats zijn sneller, maar minder accuraat.
                Console.Clear();
            double dollar = euro * 1.16;
            dollar = Math.Round(dollar, 2); // afronden gaat niet goed, bij 10 euro laat die 10,6 dollar zien? OPGELOST met String.Format
           
                Console.WriteLine(euro + " Euro " + "Is " + String.Format("{0:F2}",dollar) + " Dollar "); // String.Format gebruikt?
                Console.ReadKey();
                Console.Clear();
            */

            // Ideale gewicht
                Console.WriteLine("Bent U een Man of een Vrouw? Typ 'm'voor man of 'v' voor vrouw.");
            string gender = Console.ReadLine();

            if (gender == "m")  // == equals, / > greater than | < smaller than | >= greater of equal| 
            {
                Console.WriteLine("Voer uw lichaamslengte in centimeters");
                int centimeters = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                double Manlengte = (centimeters - 100) * 0.9;
                Console.WriteLine("Meneer, uw ideale gewicht is" + " " + Manlengte + "kilo.");
                Console.ReadKey();
                Console.Clear();
            }
            else if (gender == "v")
            {
                Console.WriteLine("Voer uw lichaamslengte in (centimeters):");
                int centimeters = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Voer uw polsomtrek in (centimeters):");
                int polscm = Convert.ToInt32(Console.ReadLine());
                double Vrlengte = (centimeters + 4 * polscm - 100) / 2;
                Console.WriteLine("Mevrouw, uw ideale gewicht is " + Vrlengte + " kilo.");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {   // Loop om terug te komen bij de eerste 'if'?
                Console.WriteLine("Graag een legitieme gender invoeren AUB");
                
            }

            Console.ReadKey();
            Console.Clear();
            int taal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Push number of preffered language:" + Environment.NewLine + "1"+": Nederlands" + Environment.NewLine + "2"+": English" + Environment.NewLine + "3"+": Fransois" + Environment.NewLine + "4" + "Spanish");

            if (taal == 1)
            {
                Console.WriteLine("Tot Ziens!");
                Console.ReadKey();
            }
            if (taal == 2)
            {
                Console.WriteLine("Bye Bye!");
                Console.ReadKey();
            }
            if (taal == 3)
            {
                Console.WriteLine("Au Revoir");
                Console.ReadKey();
            }
            if (taal == 4)
            {
                Console.WriteLine("Adios Amigos");
                Console.ReadKey();
            }

            Console.ReadKey();
            Console.Clear();

           

            

            
                


        }
    }
}

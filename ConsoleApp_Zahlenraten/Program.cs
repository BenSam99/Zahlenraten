using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Zahlenraten;

namespace ConsoleApp_Zahlenraten
{
    class Program
    {
        static void Main(string[] args)
        {
            string eingabe = "";
            do
            {
                Console.WriteLine("Wählen sie einen Schwierigkeitsgrad aus.");
                Console.WriteLine("Easy");
                Console.WriteLine("Normal");
                Console.WriteLine("Hard");
                Console.WriteLine("Extreme");



                eingabe = Console.ReadLine();

                if (eingabe == "Easy")
                {
                    Console.WriteLine("Difficulty = Easy");
                    Console.WriteLine("Bitte erraten sie die gesuchte Zahl, sie befindet sich zwischen 1 und 50.");
                    Library_Zahlenraten.Logic.Difficulty_1();
                }

                else if (eingabe == "Normal")
                {
                    Console.WriteLine("Difficulty = Normal");
                    Console.WriteLine("Bitte erraten sie die gesuchte Zahl, sie befindet sich zwischen 1 und 100");
                    Library_Zahlenraten.Logic.Difficulty_2();

                }

                else if (eingabe == "Hard")
                {
                    Console.WriteLine("Difficulty = Hard");
                    Console.WriteLine("Bitte erraten sie die Gesuchte Zahl, sie befindet sich zwischen 1 und 1000");
                    Library_Zahlenraten.Logic.Difficulty_3();
                }

                else if (eingabe == "Extreme")
                {
                    Console.WriteLine("Difficulty = Extreme");
                    Console.WriteLine("Bitte erraten sie die gesuchte Zahl, sie befindet sich zwischen 1 und 10.000");
                    Library_Zahlenraten.Logic.Difficulty_4();
                }
                else if (eingabe == "Exit")
                {
                    Console.WriteLine("Programm wird geschlossen");
                    break;
                }
                else
                {
                    Console.WriteLine("Du hast einen Fehler in der Eingabe, wähle einen der Verfügbaren Schwierigkeitsgraden aus.");
                    Console.WriteLine("Easy");
                    Console.WriteLine("Normal");
                    Console.WriteLine("Hard");
                    Console.WriteLine("Extreme");
                }

                string Ausgabe = "";
                do
                {

                    eingabe = Console.ReadLine();
                    Ausgabe = Library_Zahlenraten.Logic.proof(eingabe);
                    Console.WriteLine(Ausgabe);

                } while (Ausgabe!= null);

            } while (eingabe != "Exit");
        }
    }
}

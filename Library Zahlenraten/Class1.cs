using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Zahlenraten
{
    public class Class1
    {

    }
    public static class Logic
    {
        static int x = 0;
        public static string Abbruch = "";
        static int counter = 0;
        public static string proof(String Eingabe)
        {

            if (x != 0)
            {
                int random = x;
                int EingabeInt = 0;

                try
                {
                    EingabeInt = int.Parse(Eingabe);

                }
                catch (Exception e)
                {
                    return "Du hast einen Fehler in der Angabe";
                }

                counter = counter + 1;
                if (EingabeInt > random)
                    return "Die gesuchte Zahl ist kleiner";
                else if (EingabeInt < random)
                    return "Die gesuchte Zahl ist größer";
                else
                    return "Glückwunsch die von ihnen eingegebene Zahl " + random + " stimmt mit der gesuchten Zahl überein. Sie haben " + counter + " Versuche gebraucht. Willst du noch einaml spielen? ";
            }
            else
                return "Bitte wählen sie zuerst einen Schwierigkeitsgrad";
            

            
        }
        public static void Difficulty_1()
        {
           x = GetRandom(1, 50);
        }
        public static void Difficulty_2()
        {
            x = GetRandom(1, 100);
        }
        public static void Difficulty_3()
        {
            x = GetRandom(1, 1000);
        }
        public static void Difficulty_4()
        {
            x = GetRandom(1, 10000);
        }

        public static void Clear()
        {
            x = 0;
            counter = 0;
        }

        private static int GetRandom(int lower, int upper)
        {
            Random r = new Random();
            return r.Next(lower, upper);
        }
        public static int Counter()
        {
            return counter;
        }
    }
}

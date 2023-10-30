using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Mr.Robot.Final.Version
{
    class Archivments
    {
        static List<string> names = new List<string> { };
        public static void A1()
        {
            names.Add("Odblokowanie drzwi.");
        }
        public static void A2()
        {
            names.Add("Włamanie się do komputera w pokoju.");
        }
        public static void A3()
        {
            names.Add("Zdobycie broni i karty ochroniarza.");
        }
        public static void A4()
        {
            names.Add("Samobójstwo.");
        }
        public static void A5()
        {
            names.Add("Ucieczka z elektrowni.");
        }
        public static void A7()
        {
            names.Add("Wybuch reaktora.");
        }
        public static void A8()
        {
            names.Add("Ukończenie gry eXit.");
        }
        public static void A9()
        {
            names.Add("Zatrzymanie reaktora.");
        }
        public static void A10()
        {
            names.Add("Wejście na teren elektrowni.");
        }
        public static void A11()
        {
            names.Add("Zainstalowanie Malware.");
        }
        public static void YourArchivments()
        {
            foreach (var name in names)
            {
                Console.WriteLine("> " + name);
            }
        }

        public static void ShowArchivments()
        {
            Console.WriteLine(">>>> Wszystkie możliwe osiągnięcia do zdobycia: ");
            Console.WriteLine("> Wejście na teren elektrowni.");
            Console.WriteLine("> Zainstalowanie Malware'a.");
            Console.WriteLine("> Odblokowanie drzwi.");
            Console.WriteLine("> Włamanie się do komputera w pokoju.");
            Console.WriteLine("> Zdobycie broni i karty ochroniarza.");
            Console.WriteLine("> Samobójstwo.");
            Console.WriteLine("> Ucieczka z elektrowni.");
            Console.WriteLine("> Wybuch reaktora.");
            Console.WriteLine("> Ukończenie gry eXit.");
            Console.WriteLine("> Zatrzymanie reaktora.");
            Console.WriteLine(">>>> Zdobyte przez Ciebie osiągnięcia: ");
            YourArchivments();
            Console.WriteLine("Naciśnij dowolny klawisz, aby wrócić do Menu Końcowego.");
            Console.ReadKey();
            Game.RunEndMenu();

        }
    }
}

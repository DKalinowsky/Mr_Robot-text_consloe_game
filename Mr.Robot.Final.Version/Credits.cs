using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Threading;

namespace Mr.Robot.Final.Version
{
    class Credits
    {
        public static void ShowOff()
        {
            Console.WriteLine("Tak właściwie to tylko jeden twórca, pomysłodawca i wykonawca ;P");
            Thread.Sleep(1000);
            Console.WriteLine("Dawid Kalinowski");
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby wrócić do Menu Końcowego");
            Console.ReadKey();
            Game.RunEndMenu();
        }
    }
}

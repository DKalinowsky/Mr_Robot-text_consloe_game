using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Threading;

namespace Mr.Robot.Final.Version
{
    class eXit
    {
        public static void eXitGame()
        {
            /*var music = new Sound();*/
            string path1 = System.IO.Directory.GetCurrentDirectory() + "\\eXit.wav";
            /*music.PlayBackGroundMusic(path1);*/
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "You're trapped in a dungeon with your friend.\n" + "You see a barrel.\n" + "What do you do ?\n";
            string[] options = { "Move the barrel.", "Nothing." };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); MoveBarrel(); break;
                case 1: Console.Clear(); FirstNothing(); break;
            }
        }
        private static void MoveBarrel()
        {
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "The barrel rolls aside and you find a secret tunnel.\n" + "What do you do ?\n";
            string[] options = { "Enter tunnel.", "Nothing." };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); EnterTunnel(); break;
                case 1: Console.Clear(); SecondNothing(); break;
            }
        }
        private static void FirstNothing()
        {
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "You are still standing in the dungeon with your friend.\n" + "What do you do ?\n";
            string[] options = { "Sit down next to my friend.", "Move the barrel." };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); SitDown(); break;
                case 1: Console.Clear(); MoveBarrel(); break;
            }
        }
        private static void SitDown()
        {
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Your friend hands you a note.\n" + "What do you do ?\n";
            string[] options = { "Read note" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); SecondReadNote(); break;
            }
        }
        private static void SecondReadNote()
        {
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "It is too dark to read the note.\n" + "What do you do ?\n";
            string[] options = { "Light a match" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); SecondLight(); break;
            }
        }
        private static void SecondLight()
        {
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "The note says, Don't leave me here.\n" + "What do you do ?\n";
            string[] options = { "Leave my friend.", "Stay with my friend." };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); LeaveMyFriend(); break;
                case 1: Console.Clear(); AllPossibleEndings.Stay(); break;
            }
        }
        private static void SecondNothing()
        {
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "You are still standing in the dungeon with your friend.\n" + "What do you do ?\n";
            string[] options = { "Sit down next to my friend.", "Enter tunnel" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); SitDown(); break;
                case 1: Console.Clear(); EnterTunnel(); break;
            }
        }
        private static void EnterTunnel()
        {
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "You start to escape but your friend is too weak to go with you.\n" + "He hand you a note.\n" + "What do you do ?\n";
            string[] options = { "Read note.", "Leave my friend and keep escaping alone." };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); ReadNote(); break;
                case 1: Console.Clear(); LeaveMyFriend(); break;
            }
        }
        private static void ReadNote()
        {
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "It is too dark to read the note.\n" + "What do you do ?\n";
            string[] options = { "Light a match", "Leave my friend and keep escaping alone." };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); FirstLight(); break;
                case 1: Console.Clear(); LeaveMyFriend(); break;
            }
        }
        private static void LeaveMyFriend()
        {
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "You crawl through the tunnel and the tunnel leads you to a beach.\n" + "What do you do ?\n";
            string[] options = { "Look around." };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); LookAround(); break;
            }
        }
        private static void LookAround()
        {
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "In the water you see a boat.\n" + "What do you do ?\n";
            string[] options = { "Get on the boat." };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); Boat(); break;
            }
        }
        private static void Boat()
        {
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            Archivments.A8();
            string prompt = "Congratulations, you're heading to a new world !\n" + "Do you want to play again ?\n" + ">>>> Zauważasz, że nie udało Ci się zatrzymać reaktora, robi coraz cieplej, nie zostało Ci wiele czasu. <<<<\n" + "What do you do ?\n";
            string[] options = { "Yes.", "No." };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); eXitGame(); break;
                case 1: Console.Clear(); Game.Nope(); break;
            }
        }
        private static void FirstLight()
        {
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "You can't light a match, because the air is too humid.\n" + "What do you do ?\n";
            string[] options = { "Leave my friend and keep escaping alone." };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); LeaveMyFriend(); break;
            }
        }
    }
}

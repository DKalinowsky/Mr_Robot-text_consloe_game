using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Threading;

namespace Mr.Robot.Final.Version
{
    class Game
    {

        public static void Start()
        {
            /*var music = new Sound();
            string path = System.IO.Directory.GetCurrentDirectory() + "\\MainTheme.wav";
            music.PlayBackGroundMusic(path);*/
            Title = "Mr. Robot";
            CursorVisible = false;
            RunMainMenu();
        }
        private static void RunMainMenu()
        {
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = @"                  
       /'\_/`\            __              /'\_/`\                                
      /\      \     __   /\_\    ___     /\      \     __    ___   __  __        
      \ \ \__\ \  /'__`\ \/\ \ /' _ `\   \ \ \__\ \  /'__`\/' _ `\/\ \/\ \       
       \ \ \_/\ \/\ \L\.\_\ \ \/\ \/\ \   \ \ \_/\ \/\  __//\ \/\ \ \ \_\ \      
        \ \_\\ \_\ \__/.\_\\ \_\ \_\ \_\   \ \_\\ \_\ \____\ \_\ \_\ \____/      
         \/_/ \/_/\/__/\/_/ \/_/\/_/\/_/    \/_/ \/_/\/____/\/_/\/_/\/___/       
" + "\n" + "Witaj w Menu Głównym \n" + "Zalecana jest gra w trybie Pełny Ekran\n" + "Włączenie trybu Pełny Ekran jest dostępne w Opcjach Gry\n" + "Animację dialogów można pomijać klikając Enter\n";
            string[] options = { "Start", "Opcje Gry", "Wyjście" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); Plot.GameIntro(); break;
                case 1: Console.Clear(); RunOptionsMenu(); break;
                case 2: Environment.Exit(0); break;
            }
        }
        public static void RunEndMenu()
        {
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Witaj w Menu Końcowym \n";
            string[] options = { "Powrót do Menu Głównego", "Osiągnięcia", "Twórcy", "Wyjście" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); RunMainMenu(); break;
                case 1: Console.Clear(); Archivments.ShowArchivments(); break;
                case 2: Console.Clear(); Credits.ShowOff(); break;
                case 3: Environment.Exit(0); break;
            }
        }
        public static void RunOptionsMenu()
        {
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Witaj w Menu Opcji \n";
            string[] options = { "Tryb Pełnego Ekranu", "Powrót do Menu Głównego" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); FullScreen.FullScreenMode(); break;
                case 1: Console.Clear(); RunMainMenu(); break;
            }
        }
        public static void First()
        {
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Zatrzymałeś się kawałek od elektrowni.\n" + "Co robisz ?\n";
            string[] options = { "Podjedżam na parking.", "Zostawiam samochód w tym miejscu." };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); AllPossibleEndings.Parking(); break;
                case 1: Console.Clear(); Plot.SafePlace(); break;
            }
        }
        public static void PowerPlantEnterance()
        {
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Stoisz pomiędzy drzwiami na teren elektrowni, a drzwiami do budki strażnika.\n" + "Co robisz ?\n";
            string[] options = { "Próbuję otorzyć drzwi do budki strażniczej.", "Próbuję otworzyc drzwi w ogrodzeniu." };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); Closed1(); break;
                case 1: Console.Clear(); Closed2(); break;
            }
        }
        private static void Closed1()
        {
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Drzwi są zamknięte.\n" + "Co robisz ?\n";
            string[] options = { "Próbuję otworzyć zamek wytrychem, który mam w kieszeni.", "Próbuję otworzyc drzwi w ogrodzeniu." };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); Break1(); break;
                case 1: Console.Clear(); Closed2(); break;
            }
        }
        private static void Closed2()
        {
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Drzwi są zamknięte za pomocą kłódki.\n" + "Co robisz ?\n";
            string[] options = { "Próbuję otorzyć drzwi do budki strażniczej.", "Próbuję otworzyc kłódkę wytrychem, który mam w kieszeni.." };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); Closed1(); break;
                case 1: Console.Clear(); Break3(); break;
            }
        }
        private static void Break1()
        {
            /*var music = new Sound();*/
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            /*string path = System.IO.Directory.GetCurrentDirectory() + "\\Doors.wav";*/
            /*music.PlayBackGroundMusic(path);*/
            Animations.FramesAnimation(Images.lockpicking, 6, 100);
            Animations.TextAnimation("Udało Ci się otworzyć drzwi.\n", 50);
            Thread.Sleep(1000);
            /*music.StopMusic();*/
            Clear();
            /*string path1 = System.IO.Directory.GetCurrentDirectory() + "\\DoorOpen.wav";*/
            /*music.PlayBackGroundMusic(path1);*/
            Animations.TextAnimation("Wchodzisz do budki strażnika.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Przeszukujesz biurko...\n", 50);
            Thread.Sleep(3300);
            Animations.TextAnimation("Znajdujesz klucz, za pewno do kłódki do drzwi w ogrodzeniu.\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować.");
            Console.ReadKey();
            Console.Clear();
            string prompt = "Wychodzisz z budki strażnika.\n" + "Co robisz ?\n";
            string[] options = { "Otwieram drzwi w ogrodzeniu za pomocą klucza i wchodzę na teren elektrowni" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); Break2(); break;
            }
        }
        private static void Break2()
        {
            /*var music = new Sound();*/
            Clear();
            /*string path1 = System.IO.Directory.GetCurrentDirectory() + "\\PadLock.wav";*/
           /* music.PlayBackGroundMusic(path1);*/
            Animations.FramesAnimation(Images.locks, 1, 100);
            Animations.TextAnimation("Udało Ci się otworzyć drzwi.\n", 50);
            Thread.Sleep(1000);
            /*music.StopMusic();*/
            Clear();
            /*string path2 = System.IO.Directory.GetCurrentDirectory() + "\\MetalDoor.wav";*/
            /*music.PlayBackGroundMusic(path2);*/
            Animations.TextAnimation("Wchodzisz na teren elektrowni.\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować.");
            Console.ReadKey();
            Console.Clear();
            Plot.PowerPlant();
        }
        private static void Break3()
        {
            /*var music = new Sound();*/
            Clear();
            /*string path1 = System.IO.Directory.GetCurrentDirectory() + "\\PadLock.wav";*/
            /*music.PlayBackGroundMusic(path1);*/
            Animations.FramesAnimation(Images.lockpicking, 6, 100);
            Animations.TextAnimation("Udało Ci się otworzyć drzwi.\n", 50);
            Thread.Sleep(1000);
            Clear();
            Animations.TextAnimation("Wchodzisz na teren elektrowni.\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować.");
            Console.ReadKey();
            Console.Clear();
            Plot.PowerPlant();
        }
        public static void LabPC()
        {
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Musisz się zalogować, ale konto chronione jest hasłem.\n" + "Co robisz ?\n";
            string[] options = { "Próbuję zgadnąć hasło", "Używam exploita, który łamie hasła który mam na pendrivie w kieszeni" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); FirstPassword(); break;
                case 1: Console.Clear(); Exploits.FirstExploit(); break;
            }
        }
        private static void FirstPassword()
        {
            Clear();
            Console.WriteLine("login: LabNuclearPowerPlant");
            Console.Write("password: ");
            var pas = Console.ReadLine();
            if (pas == "InternationalAtomicEnergyAgency")
            {
                Console.Clear();
                Animations.TextAnimation("You have successfully logged in.\n", 50);
                Thread.Sleep(500);
                Animations.TextAnimation("Welcome again LabNuclearPowerPlant.\n", 50);
                Thread.Sleep(1000);
                Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować.");
                Console.ReadKey();
                Console.Clear();
                Plot.Malware();
            }
            else
            {
                Console.Clear();
                Animations.TextAnimation("Your password is incorrect.\n", 50);
                Thread.Sleep(1000);
                Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować.");
                Console.ReadKey();
                Console.Clear();
                LabPC();
            }
        }
        public static void Room()
        {
            Clear();
            /*var music = new Sound();*/
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Stoisz na środku pokoju.\n" + "Widzisz drzwi, do pokoju w którym się znajdujesz, biurko i leżące zwłoki.\n" + "Co robisz ?\n";
            string[] options = { "Podchodzę do drzwi", "Podchodzę do biurka", "Podchodzę do zwłok" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); Doors(); break;
                case 1: Console.Clear(); Desk(); break;
                case 2: Console.Clear(); DeadBody(); break;
            }
        }
        private static void Doors()
        {
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Drzwi są zablokowane elektronicznym zamkiem.\n" + "Co robisz ?\n";
            string[] options = { "Próbuję wpisać kod.", "Podchodzę do biurka", "Podchodzę do zwłok" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); Code(); break;
                case 1: Console.Clear(); Desk(); break;
                case 2: Console.Clear(); DeadBody(); break;
            }
        }
        private static void Desk()
        {
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Na biurku jest telefon i komputer.\n" + "Co robisz ?\n";
            string[] options = { "Włączam komputer.", "Podnoszę słuchawkę telefonu.", "Podchodzę do drzwi", "Podchodzę do zwłok" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); RoomPC(); break;
                case 1: Console.Clear(); Phone(); break;
                case 2: Console.Clear(); Doors(); break;
                case 3: Console.Clear(); DeadBody(); break;
            }
        }
        private static void DeadBody()
        {
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "WhiteRose leży martwy z dziurą wylotową przy lewej skroni. W magazynku pistoletu nie ma żadnych naboi.";
            string[] options = { "Podchodzę do drzwi", "Podchodzę do biurka" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); Doors(); break;
                case 1: Console.Clear(); Desk(); break;
            }
        }
        private static void Code()
        {
            Clear();
            Console.Write("Podaj kod: ");
            var code = Console.ReadLine();
            if (code == "0509")
            {
                Console.Clear();
                Animations.TextAnimation("Poprawny kod, zamek odblokowany.\n", 50);
                Thread.Sleep(1000);
                Console.WriteLine("Naciśnij dwolony klawisz, aby kontynować.");
                Console.ReadKey();
                Archivments.A1();
                Decision();
            }
            else
            {
                Console.Clear();
                Animations.TextAnimation("Niewłaściwy kod, zamek dalej zablokowany.\n", 50);
                Thread.Sleep(1000);
                Console.WriteLine("Naciśnij dwolony klawisz, aby kontynować.");
                Console.ReadKey();
                Doors();
            }
        }
        private static void RoomPC()
        {
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Musisz się zalogować, ale konto chronione jest hasłem.\n" + "Co robisz ?\n";
            string[] options = { "Próbuję zgadnąć hasło", "Używam exploita, który łamie hasła który mam na pendrivie w kieszeni", "Podchodzę do drzwi", "Podnoszę słuchawkę telefonu.", "Podchodzę do zwłok" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); SecondPassword(); break;
                case 1: Console.Clear(); Exploits.SecondExploit(); break;
                case 2: Console.Clear(); Doors(); break;
                case 3: Console.Clear(); Phone(); break;
                case 4: Console.Clear(); DeadBody(); break;
            }
        }
        private static void Phone()
        {
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "W słuchawce telefonu słychać powtarzające się: zero, pięć, zero, dziewięć.\n" + "Co robisz ?\n";
            string[] options = { "Włączam komputer.", "Podchodzę do drzwi", "Podchodzę do zwłok" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); RoomPC(); break;
                case 1: Console.Clear(); Doors(); break;
                case 2: Console.Clear(); DeadBody(); break;
            }
        }
        private static void SecondPassword()
        {
            Clear();
            Console.WriteLine("login: admin");
            Console.Write("password: ");
            var pas = Console.ReadLine();
            if (pas == "FSociety")
            {
                Console.Clear();
                Animations.TextAnimation("You have successfully logged in.\n", 50);
                Thread.Sleep(500);
                Animations.TextAnimation("Welcome again admin.\n", 50);
                Thread.Sleep(1000);
                Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować.");
                Console.ReadKey();
                Console.Clear();
                Archivments.A2();
                eXit.eXitGame();
            }
            else
            {
                Console.Clear();
                Animations.TextAnimation("Your password is incorrect.\n", 50);
                Thread.Sleep(1000);
                Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować.");
                Console.ReadKey();
                Console.Clear();
                RoomPC();
            }
        }
        private static void Decision()
        {
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Stoisz przed otwartymi drzwiami.\n" + "Co robisz ?\n";
            string[] options = { "Wychodzę przez otwarte drzwi", "Podchodzę do biurka", "Podchodzę do zwłok" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); Plot.Exit(); break;
                case 1: Console.Clear(); Desk(); break;
                case 2: Console.Clear(); DeadBody(); break;
            }
        }
        public static void FirstTry()
        {
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Stoisz przy głównych drzwiach.\n" + "Co robisz ?\n";
            string[] options = { "Próbuję rozbić szybę, żeby wyjść z budynku.", "Idę szukać innego wyjścia." };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); WindowBreak(); break;
                case 1: Console.Clear(); AnotherExit(); break;
            }
        }
        private static void WindowBreak()
        {
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Nie udało Ci się rozbić szyby.\n" + "Co robisz ?\n";
            string[] options = { "Idę szukać innego wyjścia." };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); AnotherExit(); break;
            }
        }
        private static void AnotherExit()
        {
            Animations.TextAnimation("Chodzisz po całym budynku szukając jakiejkolwiek drogi wyjścia.\n", 50);
            Thread.Sleep(500);
            Archivments.A3();
            Animations.TextAnimation("Czujesz, że zrobiło się naprawdę gorąco.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Nie wiesz ile czasu zostało do ekspolzji, ale na pewno nie masz go za dużo.\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować.");
            Console.ReadKey();
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Nagle zauważasz, że ktoś leży na ziemi.\n" + "Co robisz ?\n";
            string[] options = { "Krzyczę do tej osoby.", "Podchodzę do tej osoby." };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); Scream(); break;
                case 1: Console.Clear(); ComeCloser(); break;
            }
        }
        private static void Scream()
        {
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Czekasz chwilę, jednak nie spotykasz się z żadną reakcją.\n" + "Co robisz ?\n";
            string[] options = { "Podchodzę do tej osoby." };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); ComeCloser(); break;
            }
        }
        private static void ComeCloser()
        {
            Animations.TextAnimation("Będąc wystarczająco blisko zauważasz, ogromną kałuże krwi, oraz liczne rany postrzałowe w klatce piersiowej tej osoby.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Zauważasz, że jest to ochroniarz, który tu pracował.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Znajdujesz przy jego pasie służbowy pistolet i magnetyczną przepustkę.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Bez większego zastanowienia, bierzesz oba te przedmioty.\n", 50);
            Thread.Sleep(1500);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować.");
            Console.ReadKey();
            Clear();
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Wróciłeś do głównego wejścia.\n" + "Co robisz ?\n";
            string[] options = { "Próbuje otworzyć główne drzwi za pomocą karty strażnika.", "Strzelam z pistoletu w szybę.", "Strzelam sobie w głowę." };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); Plot.OutOfPowerPlant(); break;
                case 1: Console.Clear(); Plot.OutOfPowerPlant(); break;
                case 2: Console.Clear(); AllPossibleEndings.Suicide(); break;
            }
        }
        public static void Nope()
        {
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            string prompt = "Cały czas siedzisz przy biurku.\n" + "Co robisz ?\n";
            string[] options = { "Gram jeszcze raz", "Podnoszę słuchawkę telefonu.", "Podchodzę do drzwi", "Podchodzę do zwłok" };
            Menu mainMenu = new Menu(prompt, options);
            int seletedIndex = mainMenu.Run();

            switch (seletedIndex)
            {
                case 0: Console.Clear(); eXit.eXitGame(); break;
                case 1: Console.Clear(); Phone(); break;
                case 2: Console.Clear(); Doors(); break;
                case 3: Console.Clear(); DeadBody(); break;
            }
        }
    }
}

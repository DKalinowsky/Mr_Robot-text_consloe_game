﻿using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Threading;

namespace Mr.Robot.Final.Version
{
    class AllPossibleEndings
    {
        public static void Parking()
        {
            /*var music = new Sound();*/
            Animations.TextAnimation("Podjeżdżasz do parkingu, jednak od razu zauważa Cię ochroniarz.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Podchodzi do Ciebie i prosi o pokazanie dokumentów umożliwiający wjazd na teren elektrowni.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Po chwili jednak ochroniarz Cię rozpoznaje wyciąga broń i mierzy z niej do Ciebie.\n", 50);
            Thread.Sleep(500);
            string path = System.IO.Directory.GetCurrentDirectory() + "\\GunShot.wav";
            /*music.PlayBackGroundMusic(path);*/
            Animations.TextAnimation("Słychać wystrzał...\n", 50);
            Thread.Sleep(100);
            Animations.TextAnimation("Ochroniarz zastrzelił Cię w samochodzie na parkingu.\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontunować.");
            Console.ReadKey();
            string path1 = System.IO.Directory.GetCurrentDirectory() + "\\MainTheme.wav";
            /*music.PlayBackGroundMusic(path1);*/
            Console.Clear();
            Animations.TextAnimation("Dokonałeś złego wyboru, miałeś pozostać niezauważony.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("WhiteRose wydał swoim ludziom polecenie zabić Cię, lub zatrzymać i przyprowadzić do siebie.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Musisz być bardziej ostrożny.\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontunować.");
            Console.ReadKey();
            Console.Clear();
            Animations.TextAnimation(">>>> Koniec Gry <<<<\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation(">>>> Podsumowanie:\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation(">>>> Nie udało Ci się dostać do elektrowni.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation(">>>> Zginąłeś zastrzelony przez ochroniarza na parkingu.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation(">>>> Nie udało Ci się zainstalować Malware'a w systemie.\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować.");
            Console.ReadKey();
            Game.Start();
        }
        public static void Suicide()
        {
            /*var music = new Sound();*/
            Archivments.A4();
            string path = System.IO.Directory.GetCurrentDirectory() + "\\GunShot.wav";
            /*music.PlayBackGroundMusic(path);*/
            Animations.TextAnimation("Pistolet wystrzelił.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Padasz bez życia na podłogę.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("......\n", 50);
            Console.WriteLine("......");
            Thread.Sleep(1000);
            Animations.TextAnimation("......\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynować.");
            Console.ReadKey();
            string path1 = System.IO.Directory.GetCurrentDirectory() + "\\MainTheme.wav";
            /*music.PlayBackGroundMusic(path1);*/
            Console.Clear();
            Animations.TextAnimation(">>>> Koniec Gry <<<<\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation(">>>> Podsumowanie:\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation(">>>> Nie udało Ci się uciec z elektrowni.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation(">>>> Nie udało Ci się zatrzymać reaktora, ani przywrócić chłodzenia.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation(">>>> Zginąłęś poprzez samobójstwo, a niedługo po Tobie w wyniku wybuchu reaktora zginęły setki tysięcy ludzi.\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynować.");
            Console.ReadKey();
            Game.RunEndMenu();
        }
        public static void ReactorExplosion()
        {
            /*var music = new Sound();*/
            string path1 = System.IO.Directory.GetCurrentDirectory() + "\\MainTheme.wav";
            /*music.PlayBackGroundMusic(path1);*/
            Archivments.A5();
            Archivments.A7();
            Console.Clear();
            Animations.TextAnimation("Wyszedłeś na parkinng.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Biegniesz do swojego samochodu.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Sięgasz do kieszeni po kluczyki.\n", 50);
            Thread.Sleep(1000);
            Animations.TextAnimation("Jednak nie możesz ich tam znaleźć.\n", 50);
            Thread.Sleep(1000);
            Animations.TextAnimation("Zaczynasz energicznie przeszukiwać wszystkie kieszenie.\n", 50);
            Thread.Sleep(2000);
            Animations.TextAnimation("Na szczęście znajdujesz kluczyki.\n", 50);
            Thread.Sleep(500);
            string path = System.IO.Directory.GetCurrentDirectory() + "\\CarDoors.wav";
            /*music.PlayBackGroundMusic(path);*/
            Animations.TextAnimation("Wsiadasz do samochodu.\n", 100);
            Thread.Sleep(1800);
            string path2 = System.IO.Directory.GetCurrentDirectory() + "\\CarEngine.wav";
            /*music.PlayBackGroundMusic(path2);*/
            Animations.TextAnimation("Odpalasz silnik.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Odjeżdżasz.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Jedziesz...\n", 50);
            Thread.Sleep(1000);
            Animations.TextAnimation("Jedziesz...\n", 50);
            Thread.Sleep(1000);
            Animations.TextAnimation("Nagle czujesz nagłe trzęsienie ziemi.\n", 50);
            Thread.Sleep(1000);
            Animations.TextAnimation("W lusterku widisz wielki wybuch.\n", 50);
            string path3 = System.IO.Directory.GetCurrentDirectory() + "\\BOOM.wav";
            /*music.PlayBackGroundMusic(path3);*/
            Thread.Sleep(500);
            Animations.TextAnimation("......\n", 50);
            Console.WriteLine("......");
            Thread.Sleep(500);
            Animations.TextAnimation("......\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynować.");
            Console.ReadKey();
            string path4 = System.IO.Directory.GetCurrentDirectory() + "\\MainTheme.wav";
            /*music.PlayBackGroundMusic(path4);*/
            Console.Clear();
            Animations.TextAnimation(">>>> Koniec Gry <<<<\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation(">>>> Podsumowanie:\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation(">>>> Udało Ci się uciec z elektrowni.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation(">>>> Jednak nie udało Ci się zatrzymać reaktora, ani przywrócić chłodzenia.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation(">>>> Zginąłeś w wybuchu, a z Tobą setki tysięcy ludzi.\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynować.");
            Console.ReadKey();
            Game.RunEndMenu();
        }
        public static void Stay()
        {
            /*var music = new Sound();*/
            Archivments.A9();
            string path1 = System.IO.Directory.GetCurrentDirectory() + "\\MainTheme.wav";
            /*music.PlayBackGroundMusic(path1);*/
            Animations.TextAnimation("*Komputer wyłącza się.*\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Zauważasz, że syreny ucichły.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Nagle jednak czujesz lekkie trzęsienie ziemi, czujesz uderzającą falę gorąca.\n", 50);
            string path = System.IO.Directory.GetCurrentDirectory() + "\\Fall.wav";
            /*music.PlayBackGroundMusic(path);*/
            Thread.Sleep(1000);
            Animations.TextAnimation("Pokój w którym się znajdujesz zawala się na Ciebie.\n", 100);
            Thread.Sleep(5500);
            Animations.TextAnimation("...\n", 50);
            Thread.Sleep(1000);
            Animations.TextAnimation("...\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować.");
            Console.ReadKey();
            string path2 = System.IO.Directory.GetCurrentDirectory() + "\\MainTheme.wav";
            /*music.PlayBackGroundMusic(path2);*/
            Console.Clear();
            Thread.Sleep(1000);
            Animations.TextAnimation("Otwierasz oczy.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Jesteś w szpitalu.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Obok twojego łóżka siedzi twoja siostra Darlene.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("W telewizji na przeciwko Ciebie akurat lecą wiadomości.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Prezenterka mówi o niedawnych wydarzeniach z pobliskiej elektrowni.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("O znalezionych zwłokach zamachowca i bohaterze, któremu udało się powstrzymać wybuch reaktora.\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować.");
            Console.ReadKey();
            Console.Clear();
            Animations.TextAnimation("Nagle Darlene zauważa, że się obudziłeś.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Mówi, że po wyłączeniu reaktora doszło do ekspolzji jakiejś maszyny.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("I przeżyłeś tylko dzięki temu, że pokój w którym się znajdowałeś był bardzo dobrze zabezpieczony.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("I uratował Cię przed wybuchem.\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować.");
            Console.ReadKey();
            Console.Clear();
            Animations.TextAnimation(">>>> Koniec Gry <<<<\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation(">>>> Podsumowanie:\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation(">>>> Udało Ci się zatrzymać reaktor.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation(">>>> Uratowałeś swoje życie, a wraz z nim setki tysięcy innych ludzi.\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować.");
            Console.ReadKey();
            Game.RunEndMenu();
        }
    }
}

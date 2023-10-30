using System;
using System.Threading;
using static System.Console;


namespace Mr.Robot.Final.Version
{
    class Plot
    {
        public static void GameIntro()
        {
            /*var music = new Sound();*/
            Images.IntroLogo();
            Clear();
            Animations.TextAnimation("Witaj w grze stworzonej na podstawie serialu Mr.Robot.\n", 50);
            Thread.Sleep(1000);
            WriteLine("Naciśnij dowolony klawisz aby kontynować");
            ReadKey();
            Clear();
            Animations.TextAnimation("W tej grze wcielasz się w główną postać serialu Mr. Robot, czyli Elliota Aldersona.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Pracujesz jako inżynier bezpieczeństwa teleinformatycznego.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("I cierpisz na fobię społeczną, przez co trudno Ci nawiązywać relacje z ludźmi.\n", 50);
            Thread.Sleep(1000);
            WriteLine("Naciśnij dowolony klawisz, aby zacząć grę.");
            ReadKey();
            Clear();
            Animations.TextAnimation("Twoim gównym zadaniem jest niezauważonym włamać się do elektrowni jądrowej.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Wgrać Malware'a do systemu, tak aby wyłączył wszystkie systemy i zniszczyć maszynę WhiteRose.\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontunować.");
            Console.ReadKey();
            /*music.StopMusic();*/
            Console.Clear();
            /*string path = System.IO.Directory.GetCurrentDirectory() + "\\CarDoors.wav";
            music.PlayBackGroundMusic(path);*/
            Animations.TextAnimation("Wsiadasz do samochódu...\n", 100);
            Thread.Sleep(1900);
            /*string path1 = System.IO.Directory.GetCurrentDirectory() + "\\CarEngine.wav";
            music.PlayBackGroundMusic(path1);*/
            Animations.TextAnimation("Odpalasz silnik i jedziesz do elektrowni.\n", 50);
            Thread.Sleep(1000);
            Animations.TextAnimation("Jedziesz...\n", 50);
            Thread.Sleep(2300);
            Animations.TextAnimation("Jedziesz...\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontunować.");
            Console.ReadKey();
            /*string path2 = System.IO.Directory.GetCurrentDirectory() + "\\SaveTW.wav";
            music.PlayBackGroundMusic(path2);*/
            Console.Clear();
            Animations.TextAnimation("Widzisz już elektrownię.\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontunować.");
            Console.ReadKey();
            Console.Clear();
            Images.PowerPlantImage();
        }
        public static void SafePlace()
        {
            /*var music = new Sound();*/
            Animations.TextAnimation("Zaparkowałeś niedaleko ogrodzenia otaczającego elektrownię.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Ogrodzenie to jest zdecydowanie zbyt wysokie i zakończone drutem kolczastym.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Niestety nie masz w samochodzie nic co mogłoby posłużyć do przecięcia ogrodzenia.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Więc musisz znaleźć inną drogę wejścia na teren elektrowni.\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować.");
            Console.ReadKey();
            Console.Clear();
            KeepGoing();
        }
        public static void KeepGoing()
        {
            Animations.TextAnimation("Idąc wzdłuż ogrodzonie po chwili zauważasz budkę strażnika, oraz drzwi w ogrodzeniu.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Powoli i po cichu zakradasz się bliżej.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Przez szybę zauważasz, że w środku nie ma strażnika.\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować.");
            Console.ReadKey();
            Console.Clear();
            Game.PowerPlantEnterance();
        }
        public static void PowerPlant()
        {
            /*var music = new Sound();
            string path = System.IO.Directory.GetCurrentDirectory() + "\\Music1.wav";
            music.PlayBackGroundMusic(path);*/
            Archivments.A10();
            Animations.TextAnimation("Ostrożnie, żeby nie dać się zauważyć idziesz przez teren elektrowni, zbliżając się do wejścia.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Przez okno widzisz, że cała recepcja jest pusta.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Więc wchodzisz głównym wejściem do środka elektrowni.\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynować.");
            Console.ReadKey();
            Console.Clear();
            Animations.TextAnimation("Aby zainstalować Malware musisz dostać się do systemu.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Musisz znaleźć dowolny komputer, który będzie miał do niego dostęp.\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynować.");
            Console.ReadKey();
            Console.Clear();
            Animations.TextAnimation("Wchodzisz po schodach szukając pokoju, w którym byłby komputer.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Po pewnym czasie przez szklaną szybę zauważasz labolatorium, w którym jest pełno komputerów.\n", 50);
            Thread.Sleep(500);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynować.");
            Console.ReadKey();
            Console.Clear();
            Animations.TextAnimation("Wchodzisz do środka.\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynować.");
            Console.ReadKey();
            Console.Clear();
            Animations.TextAnimation("Siadasz przy biurku i włączasz komputer.\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynować.");
            Console.ReadKey();
            Console.Clear();
            Game.LabPC();
        }
        public static void Malware()
        {
            Archivments.A11();
            Animations.TextAnimation("Udało Ci się zalogować na komputer teraz już tylko musisz zainstalowac Malware\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynować.");
            Console.ReadKey();
            Console.Clear();
            Animations.TextAnimation("Please wait, Malware installing in progress...\n", 50);
            Thread.Sleep(1500);
            Console.WriteLine("root:00401280 ; __stdcall WinMain(x,x,x,x)");
            Thread.Sleep(100);
            Console.WriteLine("root:00401280 _WinMain@16  proc near   ; CODE XREF: start + C9p");
            Thread.Sleep(100);
            Console.WriteLine("root:00401280");
            Thread.Sleep(100);
            Console.WriteLine("root:00401280 hInstance = dword ptr  4");
            Thread.Sleep(100);
            Console.WriteLine("root:00401280");
            Thread.Sleep(100);
            Console.WriteLine("root:00401280  mov eax, [esp + hInstance]");
            Thread.Sleep(100);
            Console.WriteLine("root: 00401284  push    0; dwInitParam");
            Thread.Sleep(100);
            Console.WriteLine("root:00401286  push offset DialogFunc; lpDialogFunc");
            Thread.Sleep(100);
            Console.WriteLine("root:0040128B push    0; hWndParent");
            Thread.Sleep(100);
            Console.WriteLine("root:0040128D  push    65h; lpTemplateName");
            Thread.Sleep(100);
            Console.WriteLine("root:0040128F  push eax; hInstance");
            Thread.Sleep(100);
            Console.WriteLine("root:00401290  mov dword_405554, eax");
            Thread.Sleep(100);
            Console.WriteLine("root: 00401295  call ds:DialogBoxParamA; Create a modal dialog box from a");
            Thread.Sleep(100);
            Console.WriteLine("root:00401295; dialog box template resource");
            Thread.Sleep(100);
            Console.WriteLine("root: 0040129B mov eax, hHandle");
            Thread.Sleep(100);
            Console.WriteLine("root:004012A0 push    INFINITE; dwMilliseconds");
            Thread.Sleep(100);
            Console.WriteLine("root:004012A2 push    eax; hHandle");
            Thread.Sleep(100);
            Console.WriteLine("root:004012A3 call    ds: WaitForSingleObject");
            Thread.Sleep(100);
            Console.WriteLine("root:004012A9 retn    10h");
            Thread.Sleep(100);
            Console.WriteLine("root:004012A9 _WinMain@16  endp");
            Thread.Sleep(100);
            Console.WriteLine("root:004010BE	mov	edi, lpWskaznikKodu");
            Thread.Sleep(100);
            Console.WriteLine("root:004010D4	mov	bl, [edi+eax]");
            Thread.Sleep(100);
            Console.WriteLine("root:00401101	jmp	short loc_401104");
            Thread.Sleep(100);
            Console.WriteLine("root:00401104 loc_401104");
            Thread.Sleep(100);
            Console.WriteLine("root:00401120 VersionInformation= _OSVERSIONINFOA ptr -94h");
            Thread.Sleep(100);
            Console.WriteLine("root:00401178	mov	ecx, [esp+94h+VersionInformation.dwPlatformId]");
            Thread.Sleep(100);
            Console.WriteLine("root:00401184	mov	lpInterfejs.bIsWindowsNT, eax");
            Thread.Sleep(1000);
            Animations.TextAnimation("Malware installed successfully, press any key to continue.\n", 50);
            Console.ReadKey();
            Console.Clear();
            DarkArmy();
        }
        private static void DarkArmy()
        {
            var music = new Sound();
            Animations.TextAnimation("Udało Ci się zainstalować Malware.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Teraz już tylko musisz opuścić teren elektrowni.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Jednak nagle zauważasz, że na krześle kilku metrów od Ciebie ktoś siedzi na krześle.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Powoli podchodzisz do tej osoby.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Zauważasz rozbity monitor.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Oraz, że osoba która siedzi na krześle ma podcięte gardło.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Odruchowo robisz kilka kroków w tył i uderzasz o coś plecami.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Odwracasz się.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Stoją przed Tobą ludzie od WhiteRose, wszyscy w maskach z karabinami MP7.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Dwóch z nich do Ciebie podchodzi, pierwszy Cie przytrzymuje, a drugi coś wstrzykuje w szyję.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Tracisz przytomność...\n", 50);
            Thread.Sleep(500);
            music.StopMusic();
            Animations.TextAnimation("...\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynować.");
            Console.ReadKey();
            Console.Clear();
            WhiteRose();
        }
        private static void WhiteRose()
        {
            var music = new Sound();
            Animations.TextAnimation("Otwierasz oczy.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Siedzisz na krześle.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Jesteś w jakimś dziwnym pomieszczeniu.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Które przypomina twój pokój z dzieciństwa.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Na środku stoji biurko, na którym stoi identyczny komputer jaki miałeś w dzieciństwie.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Przy ścianie znajduje się akwarium, z Qwerty, Twoją rybką z dzieciństwa.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Nagle drzwi się otwierają, a do pokoju wchodzi WhiteRose.\n", 50);
            Console.Clear();
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Animations.TextAnimation("WhiteRose: Witaj Elliot. Zazwyczaj przprowadzam swoich gości osobiście, ale skoro się już znamy.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("WhiteRose: To mam nadzieję, że mi wybaczysz.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("WhiteRose: Muszę Ci powiedzieć Elliot wiesz ten świat w okół nas ehhh..., jestem już nim zmęczony...\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("WhiteRose: Ludzie, których kochałem i którym ufałem wyrządzili mi naprawdę ogromną krzywdę.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("WhiteRose: Jestem już zmęczony tym całym bólem, który powoduje.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("WhiteRose: Jestem zmęczony rozczarowaniem, które przynosi życie.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("WhiteRose: Wszystko, czego kiedykolwiek chciałem.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("WhiteRose: To w końcu położyć kres tej dysfunkcji i stworzyć lepszy świat dla wszystkich.\n", 50);
            Thread.Sleep(500);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Animations.TextAnimation("Elliot: Jak do tej pory robiłeś, wszystko żeby ten świat nie był lepszy.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Elliot: Tak naprawdę chcesz go zniszczyć.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Elliot: Chcesz go zniszczyć, ponieważ nienawidzisz ludzi za to, co ci zrobili.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Elliot: I patrząc w przeszłość, widzisz jedynie zło i nienawiść.\n", 50);
            Thread.Sleep(500);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Animations.TextAnimation("WhiteRose: Elliot, proszę...\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("WhiteRose: Nie rozśmieszaj mnie.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("WhiteRose: Myślisz, że jestem tym, który chce zniszczyć świat ?\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("WhiteRose: Jestem tym, który nienawidzi ludzi ?\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("WhiteRose: Rozejrzyj się w okół siebie.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("WhiteRose: Każdego dnia włączamy wiadomości, nieustannie słyszymy od naszych przywódców, naszych naukowców i przedstawicieli róznych religii, że nasz świat się rozpada.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("WhiteRose: Jako społeczeństwo nie potrafimy żyć ze sobą w zgodzie.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("WhiteRose: Jesteśmy źródłem wszystkiego, co jest złe.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("WhiteRose: Mówi się nam, że nienawiść do samego siebie nie jest już uważana za anomalię, ale za coś normalnego.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("WhiteRose: Mówiąc tak mylisz się tak naprawdę jest wręcz przeciwnie, to moja miłość do ludzi mnie napędza.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("WhiteRose: Zawsze tak było, bo wiem, że ludzie głęboko w sercu każdego starają się być dobrzy.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("WhiteRose: Dlatego właśnie chciałem stworzyć nowy, lepszy świat.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("WhiteRose: Więc proszę nie rozśmieszaj mnie i nie oskarżaj mnie o nienawiść do ludzi, gdy ty Elliot, nosisz nienawiść jak odznakę honoru !\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("WhiteRose: Czy mam Ci przypomnieć nazwę twojego ugrupowania ?\n", 50);
            Thread.Sleep(500);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Animations.TextAnimation("Elliot: Masz rację.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Elliot: Nienawidzę ludzi.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Elliot: Boję się ich.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Elliot: Bałam się ich praktycznie przez całe życie.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Elliot: Tak, tak, nazwałełem swoją grupę fsociety, bo wiesz co ?\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Elliot: Fuck Society !\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Elliot: Społeczeństwo zasługuje na to żeby go nienawidzić.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Elliot: Ale w tym społeczeństwie są też ludzie i to nie zdarza się często.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Elliot: Tak naprawdę to rzadkość.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Elliot: Ludzie, którzy nie pozwalają Ci, abyś ich nienawidzić.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Elliot: Którzy dbają o ciebie pomimo tego, że próbujesz ich nienawidzić.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Elliot: I to naprawdę wyjątkowe, bo są nieugięci w tym co robią.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Elliot: Nie ma znaczenia jak wielką krzywdę im wyrządzisz.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Elliot: I tak dbają o ciebie.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Elliot: Nie porzucają Cię, bez względu na to, ile powodów im dajesz.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Elliot: Bez względu na to, jak bardzo praktycznie błagasz ich, aby odeszli.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Elliot: I chcesz wiedzieć, dlaczego ?\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Elliot: Ponieważ to właśnie jest miłość.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Elliot: I przez cały ból, przez który przeszedłem, przeszedłem właśnie dzięki miłości niektórych ludzi do mnie, to właśnie ona mnie leczy.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Elliot: I tak, są komplikacje.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Elliot: I ranimy się nawzajem.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Elliot: Ale mimo, że wszyscy mówią, że nie mamy szans, my ciągle tu jesteśmy i idziemy na przód.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Elliot: Łamiemy się, ale podnosimy i idziemy dalej, a to nie jest wada wręcz...\n", 50);
            Thread.Sleep(500);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            string path = System.IO.Directory.GetCurrentDirectory() + "\\Alarm.wav";
            music.PlayBackGroundMusic(path);
            Animations.TextAnimation("W tym momencie włącza się alarm, słychać syreny i mrygają czerwone światła.\n", 50);
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Red;
            Animations.TextAnimation("Elliot: Co się dzieję ?\n", 50);
            Thread.Sleep(500);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Animations.TextAnimation("WhiteRose: Wygląda na to, że chłodzenie reaktora nie działa poprawnie.\n", 50);
            Thread.Sleep(500);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Animations.TextAnimation("Elliot: Jak to możliwe, zainstalowałem malware, który uniemożliwia włączenie systemu...\n", 50);
            Thread.Sleep(500);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Animations.TextAnimation("WhiteRose: Wiem o tym.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("WhiteRose: Wiedziałem o twoim włamaniu, właśnie tak Cię znalazłem.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("WhiteRose: Ale reaktor był włączony zanim się tutaj zjawiłeś.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("WhiteRose: Więc twój exploit nie mógł zadziałać poprawnie i wyłączył tylko układ chłodzenia.\n", 50);
            Thread.Sleep(500);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Animations.TextAnimation("Elliot: Nie możesz dopuścić do wybuchu !\n", 50);
            Thread.Sleep(500);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Animations.TextAnimation("WhiteRose: Za chwilę dam setkom tysięcy ludzi nowe, lepsze życie.\n", 50);
            Thread.Sleep(500);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Animations.TextAnimation("Elliot: Powiedziałeś, że kochasz ludzi, ale dopuszczając do wybuchu nie dajesz im wyboru.\n", 50);
            Thread.Sleep(500);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Animations.TextAnimation("WhiteRose: Daję im wybór.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("WhiteRose: Dlatego tu jesteś.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("WhiteRose: Możesz podjąć decyzję.\n", 50);
            Thread.Sleep(500);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Animations.TextAnimation("Elliot: Co masz na myśli ?\n", 50);
            Thread.Sleep(500);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            string path1 = System.IO.Directory.GetCurrentDirectory() + "\\GunShot.wav";
            music.PlayBackGroundMusic(path1);
            Animations.TextAnimation("W tym momencie WhiteRose wyciąga pistolet i strzela sobie w głowę...\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dwolony klawisz, aby kontynować.");
            Console.ReadKey();
            Console.Clear();
            YourChoice();
        }
        private static void YourChoice()
        {
            var music = new Sound();
            string path1 = System.IO.Directory.GetCurrentDirectory() + "\\KaliRoot.wav";
            music.PlayBackGroundMusic(path1);
            Animations.TextAnimation("Wybór należy do Ciebie\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Możesz albo spróbować uciec i uratować swoje życie, zostawiając setki tysięcy ludzi w pobliżu elektrowni na śmierć.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Albo możesz spróbować wyłączyć reaktor zanim wybuchnie.\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynować");
            Console.ReadKey();
            Console.Clear();
            Game.Room();
        }
        public static void Exit()
        {
            /*var music = new Sound();
            string path1 = System.IO.Directory.GetCurrentDirectory() + "\\MetalDoor2.wav";
            music.PlayBackGroundMusic(path1);*/
            Animations.TextAnimation("Jak tylko przeszedłeś próg drzwi, te zatrzasnęły się bez możliwości powrotu...\n", 80);
            Thread.Sleep(500);
            Animations.TextAnimation("Stoisz w ciemnym korytarzu, który co jakiś czas rozświetlany jest przez czerwone lampy, które informują o alarmie.\n", 50);
            Thread.Sleep(500);
            /*string path = System.IO.Directory.GetCurrentDirectory() + "\\Alarm.wav";
            music.PlayBackGroundMusic(path);*/
            Animations.TextAnimation("Cały czas słyszysz syreny, które również informują o alarmie, lecz w pokoju, w którym byłeś zamknięty nie było ich słychać.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Nie mając innego wyboru idziesz przez korytarz.\n", 50);
            Thread.Sleep(500);
            /*music.StopMusic();
            string path3 = System.IO.Directory.GetCurrentDirectory() + "\\401.wav";
            music.PlayBackGroundMusic(path3);*/
            Animations.TextAnimation("Idziesz...\n", 50);
            Thread.Sleep(1500);
            Animations.TextAnimation("Idziesz...\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Zauważasz, że znalazłeś się na recepcji i znajdujesz się przy głównym wejściu do budynku.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Powoli zaczynasz odczuwać gorąco, za pewno pochodzące od przegrzewającego się reaktora.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Podchodzisz do głównych drzwi i próbujesz wyjść, jednak drzwi ani drgną. Musiały zostać zamknięte podczas alarmu.\n", 50);
            Thread.Sleep(500);
            Animations.TextAnimation("Zauważasz, że po obu stronach drzwi są okna.\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz żeby kontynuować.");
            Console.ReadKey();
            Game.FirstTry();
        }
        public static void OutOfPowerPlant()
        {
            Animations.TextAnimation("Udało Ci się rozbić szybę.\n", 50);
            Thread.Sleep(1000);
            Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować.");
            Console.ReadKey();
            AllPossibleEndings.ReactorExplosion();
        }
    }
}

using System;
using System.Collections.Generic;
using GraModel;
using static GraModel.Gra;

namespace GraCMD
{
    class Program
    {
        static void Main()
        {

            ConsoleKeyInfo userClick;
            do
            {
                Console.WriteLine("\nWitaj w grze Za dużo, za mało!");
                Console.WriteLine("Aby rozpocząć kliknij S,");
                Console.WriteLine("aby zakończyć kliknij X");
                userClick = Console.ReadKey();
            } while (userClick.Key != ConsoleKey.X && userClick.Key != ConsoleKey.S);

            if (userClick.Key == ConsoleKey.X)
            {
                Console.WriteLine("Zakończyłeś program, do zobaczenia!");
                return;
            }

            Console.WriteLine("\nLecimy dalej!");

            Game game = new Game();
            bool repeat = true;
            do
            {
                while (!game.Init()) ;

                repeat = game.Play();

            } while (repeat);

            if (repeat == false)
                Main();


        }

        class Game
        {
            int min;
            int max;
            string propozycjaS;
            int propozycja;
            public bool Init()
            {
                Console.WriteLine("Podaj zakres");
                try
                {
                    Console.Write("Pierwsza liczba: ");
                    min = int.Parse(Console.ReadLine());

                    Console.Write("Druga liczba: ");
                    max = int.Parse(Console.ReadLine());

                    if (min >= max)
                        throw new ArgumentOutOfRangeException();

                }
                catch (FormatException)
                {
                    Console.WriteLine("Nie podałeś liczb!");
                    return false;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Pierwsza liczba nie może być większa lub taka sama jak druga!");
                    return false;
                }

                return true;
            }

            public bool Play()
            {
                Gra gra = new Gra(min, max);
                bool trafiono = false;
                do
                {
                    Console.WriteLine("Jeśli chcesz wyświetlić historię odpowiedzi wpisz 'h'");
                    Console.WriteLine("Jeśli chcesz się poddać wpisz 'p'");
                    Console.Write("Podaj swoją propozycję: ");
                    propozycjaS = Console.ReadLine();

                    try
                    {
                        propozycja = int.Parse(propozycjaS);
                    }
                    catch (FormatException)
                    {
                        if (propozycjaS.ToUpper() == "H")
                            ShowHistory(gra.Historia);
                        else if (propozycjaS.ToUpper() == "P")
                        {
                            Surrender(gra);
                            break;
                        }
                        else
                            Console.WriteLine("Nie podałeś liczby ani 'h'!");
                        continue;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Wykraczasz poza ustalony przez siebie zakres!");
                        continue;
                    }
                    Odp ocena = gra.Ocena(propozycja);
                    if (ocena == Odp.Trafiono)
                        trafiono = true;
                    Console.WriteLine($"{ocena}");
                } while (!trafiono);

                return false;

            }

            public void ShowHistory(List<Ruch> historia)
            {
                foreach (var h in historia)
                {
                    Console.WriteLine(h.ToString());
                }
            }

            public void Surrender(Gra gra)
            {
                gra.Poddaj();
                Console.WriteLine("Poddałeś się! Czy chcesz zobaczyć jaka liczba została wylosowana? T/N");
                ConsoleKeyInfo yesOrNo;
                do
                {
                    yesOrNo = Console.ReadKey();
                } while (yesOrNo.Key != ConsoleKey.T && yesOrNo.Key != ConsoleKey.N);

                if (yesOrNo.Key == ConsoleKey.T)
                    Console.WriteLine($"\nWylosowana liczba to: {gra.CoByloWylosowane()}");
            }

        }
    }
}

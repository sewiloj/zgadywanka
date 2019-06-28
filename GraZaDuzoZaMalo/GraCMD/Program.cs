using System;
using GraModel;
using static GraModel.Gra;

namespace GraCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo userClick;
            do
            {
                Console.WriteLine("\nWitaj w grze Za dużo, za mało!");
                Console.WriteLine("Aby rozpocząć kliknij S,");
                Console.WriteLine("aby zakończyć kliknij X");
                userClick = Console.ReadKey();
            } while (userClick.Key != ConsoleKey.X && userClick.Key != ConsoleKey.S);

            if(userClick.Key == ConsoleKey.X)
            {
                Console.WriteLine("Zakończyłeś program, do zobaczenia!");
                return;
            }

            Console.WriteLine("\nLecimy dalej!");
            Play();

        }

        private static void Play()
        {
            int min = 0;
            int max = 0;
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
            catch(FormatException)
            {
                Console.WriteLine("Nie podałeś liczb!");
                Play();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Pierwsza liczba nie może być większa lub taka sama jak druga!");
                Play();
            }

            Gra gra = new Gra(min, max);
            int propozycja = -1;
            do
            {
                Console.Write("Podaj swoją propozycję: ");
                propozycja = int.Parse(Console.ReadLine());
                Console.Write($"{gra.Ocena(propozycja)}");
            } while (gra.Ocena(propozycja) != Odp.Trafiono);






        }
    }
}

using GraModel;
using System;

namespace GraCMDInaczej
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w grze");

            Game game = new Game();
            bool repeat = true;
            do
            {
                while (!game.Init());

                repeat = game.Play();

            } while (repeat);

        }
    }

    class Game
    {
        int min;
        int max;

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



            return true;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProceduralnie
{
    class Program
    {
            int Losuj(int min, int max)
            {
                Random generator = new Random();
                int wylosowana = generator.Next(min, max + 1);
                return 0;
            }
        static void Main(string[] args)
        {
            


            Random generator = new Random();
            int wylosowana = generator.Next(1, 101);
            Console.WriteLine("Wylosowałem liczbę od 1 do 100. \n Odgadnij ją");

#if(DEBUG)
            Console.WriteLine(wylosowana);
#endif

            //wykonuj
            bool trafiono = false; //wartownik (zwany czasami flagą)
            do
            {
                #region Krok 2. Człowiek proponuje rozwiązanie
                Console.Write("Podaj swoją propozycję: ");
                string tekst = Console.ReadLine();
                if (tekst.ToLower() == "x")
                    break;

                int propozycja = 0;
                try
                {
                    propozycja = Convert.ToInt32(tekst);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nie podano liczby!");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Liczba nie mieści się w rejestrze!");
                    continue;
                }

                Console.WriteLine($"Przyjąłem wartość {propozycja}");
                #endregion


                #region Krok 3. Komputer ocenia propozycję
                if (propozycja < wylosowana)
                    Console.WriteLine("za mało");
                else if (propozycja > wylosowana)
                    Console.WriteLine("za dużo");
                else
                {
                    Console.WriteLine("trafiono");
                    trafiono = true;
                }
                #endregion
            }
            while (!trafiono);
            //do momentu trafienia

            Console.WriteLine("Koniec gry");
        }
    }
}

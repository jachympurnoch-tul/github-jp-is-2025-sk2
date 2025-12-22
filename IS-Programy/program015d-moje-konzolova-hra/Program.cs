using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string again = "a";
        Random rnd = new Random();

        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("************ MINOVÉ POLE ***********");
            Console.WriteLine("====================================");
            Console.WriteLine();

            int minPozice = 1;
            int maxPozice = 20;
            int pocetMin = 5;

            HashSet<int> miny = new HashSet<int>();
            HashSet<int> navstivene = new HashSet<int>();

            while (miny.Count < pocetMin)
            {
                miny.Add(rnd.Next(minPozice, maxPozice + 1));
            }

            bool konec = false;
            int aktualniPozice = 0;

            Console.WriteLine($"Pole má {maxPozice} pozic a {pocetMin} min.");
            Console.WriteLine("Cílem je dojít co nejdál bez výbuchu.");
            Console.WriteLine();

            while (!konec)
            {
                Console.Write("Zadej pozici, kam chceš vstoupit: ");
                if (!int.TryParse(Console.ReadLine(), out aktualniPozice))
                {
                    Console.WriteLine("Neplatný vstup!");
                    continue;
                }

                if (aktualniPozice < minPozice || aktualniPozice > maxPozice)
                {
                    Console.WriteLine("Mimo rozsah!");
                    continue;
                }

                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("************ MINOVÉ POLE ***********");
                Console.WriteLine("====================================");
                Console.WriteLine();

                if (miny.Contains(aktualniPozice))
                {
                    konec = true;
                }
                else
                {
                    navstivene.Add(aktualniPozice);
                }

                for (int i = minPozice; i <= maxPozice; i++)
                {
                    if (konec && miny.Contains(i))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("* ");
                    }
                    else if (i == aktualniPozice && !konec)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("O ");
                    }
                    else if (navstivene.Contains(i))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("✓ ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(". ");
                    }
                }

                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();

                if (konec)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("💥 Šlápl jsi na minu! Konec hry.");
                    Console.ResetColor();
                    Console.WriteLine($"Bezpečných kroků: {navstivene.Count}");
                }
                else
                {
                    Console.WriteLine("✔ Bezpečno. Můžeš pokračovat...");
                }

                Console.WriteLine();
            }

            Console.Write("Pro opakování stiskni 'a': ");
            again = Console.ReadLine();
        }
    }
}

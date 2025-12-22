using System;
using System.Collections.Generic;

class Program
{
    static int PocetMinVOkoli(int pozice, HashSet<int> miny, int min, int max)
    {
        int pocet = 0;
        for (int i = pozice - 2; i <= pozice + 2; i++)
        {
            if (i >= min && i <= max && i != pozice && miny.Contains(i))
                pocet++;
        }
        return pocet;
    }

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
            Console.WriteLine("========== Jáchym Purnoch ==========");
            Console.WriteLine("====================================");
            Console.WriteLine();

            int minPozice = 1;
            int maxPozice = 20;
            int pocetMin = 3;

            HashSet<int> miny = new HashSet<int>();
            HashSet<int> navstivene = new HashSet<int>();

            while (miny.Count < pocetMin)
                miny.Add(rnd.Next(minPozice, maxPozice + 1));

            bool konec = false;
            int aktualniPozice = 0;

            Console.WriteLine($"Pole má {maxPozice} pozic a {pocetMin} min.");
            Console.WriteLine("Po bezpečném kroku dostaneš nápovědu (±2).");
            Console.WriteLine("Úkolem je získat co nejvíce bezpečných krok!");
            Console.WriteLine();

            while (!konec)
            {
                Console.Write("Zadej pozici: ");
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
                Console.WriteLine("========== Jáchym Purnoch ==========");
                Console.WriteLine("====================================");
                Console.WriteLine();

                if (miny.Contains(aktualniPozice))
                    konec = true; // šlápl na minu → prohra
                else
                    navstivene.Add(aktualniPozice); // bezpečné pole

                // ====== ŘÁDEK S POLEM ======
                for (int i = minPozice; i <= maxPozice; i++)
                {
                    if (konec && miny.Contains(i))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("*".PadLeft(3));
                    }
                    else if (i == aktualniPozice && !konec)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("O".PadLeft(3));
                    }
                    else if (navstivene.Contains(i))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("✓".PadLeft(3));
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(".".PadLeft(3));
                    }
                }

                Console.ResetColor();
                Console.WriteLine();

                // ====== ŘÁDEK S ČÍSLY (ZAROVNANÝ) ======
                for (int i = minPozice; i <= maxPozice; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(i.ToString().PadLeft(3));
                }

                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();

                // ===== Kontrola konce hry =====
                if (konec)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("💥 Šlápl jsi na minu! Konec hry.");
                    Console.ResetColor();
                    Console.WriteLine($"Bezpečných kroků: {navstivene.Count}");

                    Console.Write("Pozice všech min byly: ");
                    foreach (int mina in miny)
                        Console.Write(mina + " ");
                    Console.WriteLine();
                }
                else if (navstivene.Count == maxPozice - pocetMin)
                {
                    // Pokud hráč označil všechna bezpečná pole → výhra
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("🎉 Nalezl jsi všechna bezpečná pole! Vyhrál jsi!");
                    Console.ResetColor();

                    Console.Write("Pozice všech min byly: ");
                    foreach (int mina in miny)
                        Console.Write(mina + " ");
                    Console.WriteLine();

                    konec = true; // konec hry
                }
                else
                {
                    int minyOkoli = PocetMinVOkoli(aktualniPozice, miny, minPozice, maxPozice);
                    Console.WriteLine($"⚠ V okolí (±2) je {minyOkoli} min.");
                }

                Console.WriteLine();
            }

            Console.Write("Pro opakování stiskni 'a': ");
            again = Console.ReadLine();
        }
    }
}

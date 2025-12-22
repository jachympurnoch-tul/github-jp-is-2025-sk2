﻿using System;

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
            Console.WriteLine("************* LOV POKLADU **********");
            Console.WriteLine("====================================");
            Console.WriteLine();

            // nastavení hranic
            int minPozice = 1;
            int maxPozice = 20;

            // náhodné umístění pokladu
            int poklad = rnd.Next(minPozice, maxPozice + 1);
            int tip = 0;
            int pokus = 0;
            bool nalezen = false;

            Console.WriteLine($"Poklad je schován někde mezi {minPozice} a {maxPozice}...");
            Console.WriteLine();

            // hlavní herní smyčka
            while (!nalezen)
            {
                Console.Write($"Zadej číslo ({minPozice}–{maxPozice}): ");
                if (!int.TryParse(Console.ReadLine(), out tip))
                {
                    Console.WriteLine("Nezadali jste celé číslo!");
                    continue;
                }

                if (tip < minPozice || tip > maxPozice)
                {
                    Console.WriteLine("Číslo je mimo povolený rozsah!");
                    continue;
                }

                pokus++;

                // vymazání obrazovky a zobrazení aktuálního stavu
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("************* LOV POKLADU **********");
                Console.WriteLine("====================================");
                Console.WriteLine();

                // vizualizace pole
                for (int i = minPozice; i <= maxPozice; i++)
                {
                    if (i == tip)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("O ");
                    }
                    else if (i == poklad && nalezen)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("X ");
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

                // kontrola tipu
                if (tip < poklad)
                {
                    Console.WriteLine("➡ Poklad je vpravo!");
                }
                else if (tip > poklad)
                {
                    Console.WriteLine("⬅ Poklad je vlevo!");
                }
                else
                {
                    nalezen = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n💎 Našel jsi poklad po {pokus} pokusech!");
                    Console.ResetColor();

                    // po nalezení vykreslíme poklad znovu s X
                    Console.WriteLine();
                    for (int i = minPozice; i <= maxPozice; i++)
                    {
                        if (i == poklad)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("X ");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(". ");
                        }
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Pro opakování stiskni klávesu 'a': ");
            again = Console.ReadLine();
        }
    }
}
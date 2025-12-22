﻿using System;
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
            Console.WriteLine("************* LOV POKLADU **********");
            Console.WriteLine("====================================");
            Console.WriteLine();

            int minPozice = 1;
            int maxPozice = 20;
            int poklad = rnd.Next(minPozice, maxPozice + 1);
            int tip = 0;
            int pokus = 0;
            bool nalezen = false;

            // seznam všech dříve hádaných pozic
            List<int> hadanePozice = new List<int>();

            Console.WriteLine($"Poklad je schován někde mezi {minPozice} a {maxPozice}...");
            Console.WriteLine();

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

                // přidáme tip do seznamu, pokud tam ještě není
                if (!hadanePozice.Contains(tip))
                    hadanePozice.Add(tip);

                pokus++;

                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("************* LOV POKLADU **********");
                Console.WriteLine("====================================");
                Console.WriteLine();

                // vizualizace všech pozic
                for (int i = minPozice; i <= maxPozice; i++)
                {
                    if (i == poklad && nalezen)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("X ");
                    }
                    else if (i == tip)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("O ");
                    }
                    else if (hadanePozice.Contains(i))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("x ");
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

                    Console.WriteLine();
                    for (int i = minPozice; i <= maxPozice; i++)
                    {
                        if (i == poklad)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("X ");
                        }
                        else if (hadanePozice.Contains(i))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("x ");
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
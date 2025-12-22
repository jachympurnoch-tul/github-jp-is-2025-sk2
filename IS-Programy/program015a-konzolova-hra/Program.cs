
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

            int poklad = rnd.Next(1, 21); // poklad schovaný mezi 1–20
            int pokus = 0;
            int tip = 0;

            Console.WriteLine("Poklad je schován někde mezi 1 a 20...");
            Console.WriteLine();

            // hlavní herní smyčka
            while (tip != poklad)
            {
                Console.Write("Zadej číslo (1–20): ");
                if (!int.TryParse(Console.ReadLine(), out tip))
                {
                    Console.WriteLine("Zadej celé číslo!");
                    continue;
                }

                pokus++;

                if (tip < poklad)
                    Console.WriteLine("➡ Poklad je vpravo!");
                else if (tip > poklad)
                    Console.WriteLine("⬅ Poklad je vlevo!");
                else
                    Console.WriteLine($"\n💎 Našel jsi poklad po {pokus} pokusech!");
            }

            Console.WriteLine();
            Console.Write("Pro opakování stiskni klávesu 'a': ");
            again = Console.ReadLine();
        }
    }
}

using System.Runtime.InteropServices.Marshalling;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("---------- Seřazení tří čísel ---------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("---------- Výpis číselné řady ----------");
    Console.WriteLine("------ Jáchym Purnoch / 23.10.2025 -----");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine();

    Console.Write("Zadejte celé číslo A: ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Děláte machry, ale hajzl máte na chodbě! (Nezedali jste celé číslo A. Zadejte celé číslo znovu!): ");
    }

    Console.Write("Zadejte celé číslo B: ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Děláte machry, ale hajzl máte na chodbě! (Nezedali jste celé číslo B. Zadejte celé číslo znovu!): ");
    }

    Console.Write("Zadejte celé číslo C: ");
    int c;
    while (!int.TryParse(Console.ReadLine(), out c))
    {
        Console.Write("Děláte machry, ale hajzl máte na chodbě! (Nezedali jste celé číslo C. Zadejte celé číslo znovu!): ");
    }

    Console.WriteLine();


    //Chceme seřadit čísla vzestupně
    if (a > b)
    {
        if (a > c)
            Console.WriteLine($"Největší číslo je A = {a}");
        else
            Console.WriteLine($"Největší číslo je C = {c}");
    }
    else
    {
        if (b > c)
            Console.WriteLine($"Největší číslo je B = {b}");
        else
            Console.WriteLine($"Největší číslo je C = {c}");
    }

    Console.WriteLine("");
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();


}
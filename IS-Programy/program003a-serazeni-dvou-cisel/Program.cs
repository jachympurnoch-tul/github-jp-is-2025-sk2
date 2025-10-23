using System.Runtime.InteropServices.Marshalling;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("---------- Seřazení dvou čísel ---------");
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
        Console.Write("Děláte machry, ale hajzl máte na chodbě! (Nezedali jste celé číslo A. Zadejte celé číslo znovu!)");
    }

    Console.Write("Zadejte celé číslo B: ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Děláte machry, ale hajzl máte na chodbě! (Nezedali jste celé číslo B. Zadejte celé číslo znovu!)");
    }

    Console.WriteLine();

    int pom;
    //Chceme seřadit čísla vzestupně
    if (a > b)
    {
        pom = a;
        a = b;
        b = pom;
        Console.WriteLine("Došlo k prohození proměnných");
    }

    Console.WriteLine("----------------------------------------");
    Console.WriteLine($"Seřazená čísla: {a}, {b} ");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();


}
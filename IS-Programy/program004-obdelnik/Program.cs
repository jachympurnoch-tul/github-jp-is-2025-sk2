using System.Runtime.InteropServices.Marshalling;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("--------------- Obdelnik ---------------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("---------- Výpis číselné řady ----------");
    Console.WriteLine("------ Jáchym Purnoch / 23.10.2025 -----");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine();

    Console.Write("Zadejte šířku obdélníku: ");
    int width;
    while (!int.TryParse(Console.ReadLine(), out width))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte šířku obdélníku znova!: ");
    }

    Console.Write("Zadejte výšku obdélníku: ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte výšku obdélníku znova!: ");
    }

    for (int i = 1; i <= height; i++)
    {
        for (int j = 1; j <= width; j++)
        {
            Console.Write("°  ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(150));
        }
    Console.WriteLine("");
    }

    Console.WriteLine("");
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();


}
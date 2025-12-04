string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("-------------- Výpočet pí --------------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("-------Jáchym Purnoch / 2.10.2025-------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatně řešený
    // Console.Write("Zadejte první číslo řady: ");
    // int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, ale lépe řešený
    Console.Write("Zadejte první číslo řady(celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first)) 
    {
        Console.Write("Děláte machry, ale hajzl máte na chodbě! (Nezedali jste celé číslo. Zadejte první číslo řady znovu!)");
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();


}
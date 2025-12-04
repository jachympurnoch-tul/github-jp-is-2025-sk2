string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("-------------- Výpočet pí --------------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("-------Jáchym Purnoch / 4.12.2025-------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine();

    double i = 1;
    double znamenko = 1;
    double pictvrt = 0;
    double pi = Math.PI;

    Console.Write("Zadejte přesnost : ");
    double presnost;
    while (!double.TryParse(Console.ReadLine(), out presnost)) 
    {
        Console.Write("Zadejte přesnost řady znovu!: ");
    }


    while ((1/i) >= presnost)
    {
        pictvrt = pictvrt + znamenko * 1/i;
        znamenko = -znamenko;
        i = i+2;
    }

    pi = 4 * pictvrt;

    Console.WriteLine();
    Console.WriteLine("pi = {0}", pi);
    Console.WriteLine();



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();


}
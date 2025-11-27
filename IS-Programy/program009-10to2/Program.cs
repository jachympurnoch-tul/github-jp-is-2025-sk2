string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("-------Převod z 10 do 2 soustavy--------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("-----------Výpis číselné řady-----------");
    Console.WriteLine("-------Jáchym Purnoch / 2.10.2025-------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine();


    Console.Write("Zadejte desítkové číslo (přirozené): ");
    uint number10;
    while (!uint.TryParse(Console.ReadLine(), out number10)) 
    {
        Console.Write("Nezedali jste celé číslo. Zadejte desítkové číslo řady znovu!: ");
    }

    uint[] myArray = new uint[32];
    uint backupNumber10 = number10;
    uint zbytek;

    
    uint i;
    for (i=0; number10 > 0 ;i++)
    {
        zbytek = number10 % 2;
        number10 = (number10 - zbytek)/2;
        myArray[i] = zbytek;

        Console.WriteLine("Celá část: {0}, zbytek {1}", number10, zbytek);
    }

    Console.WriteLine("Desítkové číslo {0} ve binární soustavě: ", backupNumber10);
    for (uint j = i - 1; j >= 0; j--)
    {
        Console.Write("{0}", myArray[j]);
    }
    Console.WriteLine();

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
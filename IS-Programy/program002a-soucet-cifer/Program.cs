string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("---------součet a součin cifer----------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("-------Jáchym Purnoch / 2.10.2025-------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine();

    Console.Write("Zadejte celé číslo: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Děláte machry, ale hajzl máte na chodbě! (Zadejte ho znovu!)");
    }

    int suma = 0;
    int numberBackup = number;
    int digit; //zbytek

    //pokud je vstup záporný tímto ho změníme na kladný
    if (number < 0)
    {
        number = -number;
    }

    while(number >= 10)
    {
        digit = number % 10; //určí nám zbytek
        number = (number - digit) / 10;
        Console.WriteLine("Hodnota zbytku = {0}", digit);
        suma = suma + digit;
    }
    //musíme poslední cifru vypsat
    Console.WriteLine("Poslední zbytek = {0}", number);

    //musíme poslední cifru přičíst
    suma = suma + number;

    Console.WriteLine();
    Console.WriteLine("Součet cifer čísla {0} je {1}", numberBackup, suma);


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stikněte a");
    again = Console.ReadLine();

}
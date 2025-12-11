string again = "a";
while (again == "a")
{
    Console.Clear();
    razitko(); //metoda pro výpis hlavičky razítka
    ulong a = nacticislo("Zadejte přirozené číslo a: ");
    ulong b = nacticislo("Zadejte přirozené číslo b: ");

    vypocitatNSD(a, b);


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}

static void razitko()
{
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("----------- Výpočet NSD a NSN ----------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("------------ Jáchym Purnoch ------------");
    Console.WriteLine("--------------- 2.10.2025 --------------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine();
}

static ulong nacticislo(string zprava);
{
    Console.Write(zprava);
    ulong cislo;
    while (!ulong.TryParse(Console.ReadLine(), out cislo))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte vstup znovu: ");
    }

    return cislo;
}

static ulong vypocitatNSD(ulong a, ulong b)
{
    while(a != b) {
        if (a > b)
            a = a - b;
    }
    
    return a;

    


}


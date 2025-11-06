string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("-----Generátor pseudonáhodných čísel-----");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("-----------Výpis číselné řady-----------");
    Console.WriteLine("-------Jáchym Purnoch / 2.10.2025-------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatně řešený
    // Console.Write("Zadejte první číslo řady: ");
    // int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, ale lépe řešený
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezedali jste celé číslo. Zadejte počet čísel znovu!)");
    }

    Console.WriteLine("Zadejte dolní mez (celé číslo): ");
    int lowerBound; //dolní mez
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezedali jste celé číslo. Zadejte dolní mez znovu!)");
    }

    Console.WriteLine("Zadejte horní mez (celé číslo): ");
    int upperBound; //horní mez
    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezedali jste celé číslo. Zadejte horní mez znovu!)");
    }

    Console.WriteLine();
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine("počet generovaných čísel (počet čísel): {0}, Dolní mez {1}, Horní mez {2}", n, lowerBound, upperBound);
    Console.WriteLine("----------------------------------------");
    Console.WriteLine();

    //deklerace pole (array)
    int[] myRandNumbs = new int[n];

    //priprava pro vyuziti tridy Random
    //Random myRandNumb = new Random();
    Random myRandNumb = new Random();

    //kladna, zaporna nebo nuly
    int negativeNumbs = 0;
    int positiveNumbs = 0;
    int zeros = 0;

    // sudá nebo lichá
    int evenNumbs = 0;
    int oddNumbs = 0;

    Console.WriteLine();
    Console.WriteLine("Náhodná čísla: ");
    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write("{0}; ", myRandNumbs[i]);

        //zaporna, kladna, nuly
        if (myRandNumbs[i] > 0)
            positiveNumbs++;
        if (myRandNumbs[i] < 0)
            negativeNumbs++;
        if (myRandNumbs[i] == 0)
            zeros++;


        //licha a suda
        if (myRandNumbs[i] % 2 == 0)
            evenNumbs++;
        else oddNumbs++;

    }

    Console.WriteLine();
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("Počet kladných: {0}", positiveNumbs);
    Console.WriteLine("Počet záporných: {0}", negativeNumbs);
    Console.WriteLine("Počet nul: {0}", zeros);
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("Počet sudých: {0}", evenNumbs);
    Console.WriteLine("Počet lichých: {0}", oddNumbs);
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("----------------------------------------");




    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte kldávesu a");
    again = Console.ReadLine();
            










}
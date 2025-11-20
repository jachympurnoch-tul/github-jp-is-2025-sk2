using System.Diagnostics;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("------- Generátor pseudonáhodných čísel ------");
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("--------------- Jáchym Purnoch ---------------");
    Console.WriteLine("----------------- 6.11.2025 ------------------");
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu: ");
    }


    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound; // Dolní mez
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }



    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound; // Horní mez
    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
    }


    Console.WriteLine();
    Console.WriteLine("==========================================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine("Počet čísel: {0}, Dolní mez: {1}, Horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("==========================================================");
    Console.WriteLine();

    // deklarace pole (array)
    int[] myRandNumbs = new int[n];

    // příprava pro využití třídy Random
    Random myRandNumb = new Random();
    //Random myRandNumb = new Random(15);
    
    Console.WriteLine();
    Console.WriteLine("Náhodná čísla: ");
    for(int i = 0; i < n ; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
        Console.Write("{0}; ",myRandNumbs[i]);

    }

    Stopwatch myStopwatch = new Stopwatch();


    int compare = 0; //porovnávání
    int change = 0; //počet výměn

    myStopwatch.Start();
    for (int i=0; i < n - 1; i++) {
        // tento cyklus musí zajistit porovnávání dvou sousedních hodnot
        // musí dále zajistit, aby se zmenšoval počet porovnávaných hodnot
        for(int j = 0; j < n - i - 1 ; j++) {
            if(myRandNumbs[j] > myRandNumbs[j + 1]) {
                int tmp = myRandNumbs[j + 1];
                myRandNumbs[j + 1] = myRandNumbs[j];
                myRandNumbs[j] = tmp;
                change++;
            }
            compare++;
        }
    }
    myStopwatch.Stop();

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine("Seřazené pole: ");
    for(int i = 0; i < n; i++) {
        Console.Write("{0}; ",myRandNumbs[i]);
    }
    
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"počet porovnání: {compare}");
    Console.WriteLine();
    Console.WriteLine($"počet výměn: {change}");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Čas seřazení čísel pomocí bubblesort: {0}", myStopwatch.Elapsed);


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}
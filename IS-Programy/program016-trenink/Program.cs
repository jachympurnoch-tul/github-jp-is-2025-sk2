using System.ComponentModel.DataAnnotations;

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

    // deklarace pole (array)
    int[] myRandNumbs = new int[n];

    // příprava pro využití třídy Random
    Random myRandNumb = new Random();
    //Random myRandNumb = new Random(15);
    
    Console.WriteLine("Náhodná čísla: ");
    for(int i = 0; i < n ; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
        Console.Write("{0}; ",myRandNumbs[i]);

    }
    //----------------------------------------------------------------------------------------------------------------------------------
    //----------------------------------------------------------------------------------------------------------------------------------
    //----------------------------------------------------------------------------------------------------------------------------------
    //----------------------------------------------------------------------------------------------------------------------------------
    int max = myRandNumbs[0];
    int min = myRandNumbs[0];

    for(int i = 0; i < n; i++)
        {
            if(myRandNumbs[i] > max)
            {
                max = myRandNumbs[i];
            }
            if(myRandNumbs[i] < min)
            {
                min = myRandNumbs[i];
            }
        }

    Console.WriteLine();
    Console.WriteLine("=====================================================");
    Console.WriteLine("Maximum: " + max);
    Console.Write("Pozice maxima: ");
    for(int i = 0; i < n; i++)
    {
        if(myRandNumbs[i] == max)
        {
            Console.Write((i+1) + "; ");
        }
    }
    Console.WriteLine();
    Console.WriteLine("=================================================");
    Console.WriteLine("Minimum: " + min);
    Console.Write("Pozice minima: ");
    for(int i = 0; i < n; i++)
    {
        if(myRandNumbs[i] == min)
        {
            Console.Write((i+1) + "; ");
        }
    }

    //----------------------------------------------------------------------------------------------------------------------------------
    //BUBBLE SORT

    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n - 1; j++)
        {
            if(myRandNumbs[j] < myRandNumbs[j + 1])
            {
                int tmp = myRandNumbs[j];
                myRandNumbs[j] = myRandNumbs[j+1];
                myRandNumbs[j+1] = tmp;
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine("==============================================");
    Console.WriteLine("Seřazená čísla pomocí Bubble sortu: ");
    for (int i = 0; i < n; i++)
    {
        Console.Write(myRandNumbs[i]);
        if (i < n - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
    Console.WriteLine("==================================================");

    //==================================================================================================================================

    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n - 1; j++)
        {
            if(myRandNumbs[j] < myRandNumbs[j + 1])
            {
                int tmp = myRandNumbs[j];
                myRandNumbs[j] = myRandNumbs[j + 1];
                myRandNumbs[j + 1] = tmp;
            }
        }
    }
    Console.WriteLine("Seřazená čásla 2: ");
    for (int i = 0; i < n; i++)
    {
        Console.Write(myRandNumbs[i]);
        if ( i < n - 1)
        {
            Console.Write("; ");
        }
    }
    Console.WriteLine();
    Console.WriteLine("=======================================");

    //==================================================================================================================================

    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n -1; j++)
        {
            if(myRandNumbs[j] < myRandNumbs[j + 1])
            {
                int tmp = myRandNumbs[j];
                myRandNumbs[j] = myRandNumbs[j+1];
                myRandNumbs[j+1] = tmp;
            }
        }
    }

    Console.WriteLine("Seřazená čísla 3: ");
    for (int i = 0; i < n; i++)
    {
        Console.Write(myRandNumbs[i]);
        if(i < n - 1)
        {
            Console.Write("; ");
        }
    }
    Console.WriteLine();
    Console.WriteLine("=============================="); 

    //==================================================================================================================================

    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n -1; j++)
        {
            if(myRandNumbs[j] < myRandNumbs[j + 1])
            {
                int tmp = myRandNumbs[j];
                myRandNumbs[j] = myRandNumbs[j + 1];
                myRandNumbs[j + 1] = tmp;
            }
        }
    }

    Console.WriteLine("Seřazená čísla 4: ");
    for(int i = 0; i < n; i++)
    {
        Console.Write(myRandNumbs[i]);
        if(i < n - 1)
        {
            Console.Write("; ");
        }
    }
    Console.WriteLine();
    
    //==================================================================================================================================

    // int c1 = myRandNumbs[0];
    // int c2 = 0;
    // int c3 = 0;
    // int c4 = 0;
    // int c5 = 0;
    // int c6 = 0;
    // int c7 = 0;

    // for(int i = 0; i < n; i++)
    // {
    //     int aktualni = myRandNumbs[i];
    //     if(aktualni < c1)
    //     {
    //         if(c2 == 0)
    //         {
    //             c2 = aktualni;
    //         }
    //     }
    //     if (aktualni < c2)
    //     {
    //         if(c3 == 0)
    //         {
    //             c3 = aktualni;
    //         }
    //     }
    //     if (aktualni < c3)
    //     {
    //         if(c4 == 0)
    //         {
    //             c4 = aktualni;
    //         }
    //     }
    //     if (aktualni < c4)
    //     {
    //         if(c5 == 0)
    //         {
    //             c5 = aktualni;
    //         }
    //     }
    //     if (aktualni < c5)
    //     {
    //         if(c6 == 0)
    //         {
    //             c6 = aktualni;
    //         }
    //     }
    //     if (aktualni < c6)
    //     {
    //         if(c7 == 0)
    //         {
    //             c7 = aktualni;
    //         }
    //     }
    // }
    // Console.WriteLine("Největší čísla 2: ");
    // Console.WriteLine("2.největší číslo: " + c2);
    // Console.WriteLine("3.největší číslo: " + c3);
    // Console.WriteLine("4.největší číslo: " + c4);
    // Console.WriteLine("5.největší číslo: " + c5);
    // Console.WriteLine("6.největší číslo: " + c6);
    // Console.WriteLine("7.největší číslo: " + c7);

    //----------------------------------------------------------------------------------------------------------------------------------
    //Nejvetsi cisla
    int c1 = myRandNumbs[0];
    int c2 = 0;
    int c3 = 0;
    int c4 = 0;
    int c5 = 0;

    for (int i = 0; i < n; i++)
    {
        int aktualni = myRandNumbs[i];
        // Hledáme 2. místo
        if (aktualni < c1)
        {
            if (c2 == 0)
            {
                c2 = aktualni;
            }
        }

        // Hledáme 3. místo
        if (aktualni < c2)
        {
            if (c3 == 0)
            {
                c3 = aktualni;
            }
        }

        // Hledáme 4. místo
        if (aktualni < c3)
        {
            if (c4 == 0)
            {
                c4 = aktualni;
            }
        }

        //Hledama 5. misto
        if(aktualni < c4)
        {
            if(c5 == 0)
            {
                c5 = aktualni;
            }

        }
    }

    Console.WriteLine("2. největší: " + c2);
    Console.WriteLine("3. největší: " + c3);
    Console.WriteLine("4. největší: " + c4);
    Console.WriteLine("5. největší: " + c5);
    Console.WriteLine("=============================================");

    //----------------------------------------------------------------------------------------------------------------------------------
    //Median
    int median = myRandNumbs[n / 2];
    Console.WriteLine("Medián: " + median);
    Console.WriteLine("================================================");

    //----------------------------------------------------------------------------------------------------------------------------------
    //Prevedeni do binarni soustavy
    string binarni = Convert.ToString(c4, 2);
    Console.WriteLine("Čtvrté největší číslo (" + c4 + ") binárně: " + binarni);


    Console.WriteLine("==============================================");
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}
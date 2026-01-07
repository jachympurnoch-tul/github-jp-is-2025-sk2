using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Numerics;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization;
using System.Security.AccessControl;
using System.Security.Authentication.ExtendedProtection;
using System.Xml.Schema;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("------- Generátor pseudonáhodných čísel ------");
    Console.WriteLine("--------------- test zadnání 1 ---------------");
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("--------------- Jáchym Purnoch ---------------");
    Console.WriteLine("----------------- 6.11.2025 ------------------");
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
    Console.WriteLine();

// ===================================================================================

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

    Console.WriteLine("==========================================================");
    Console.Write("Maximum: " + max + "; pozice maxima: ");
    for(int i = 0; i < n; i++)
    {
        if(myRandNumbs[i] == max)
        {
            Console.Write((i) + "; ");
        }
    }

    Console.Write("Minimum: " + min + "; pozice minima: ");
    for(int i = 0; i < n; i++)
    {
        if(myRandNumbs[i] == min)
        {
            Console.Write((i) + "; ");
        }
    }
    Console.WriteLine("");
    Console.WriteLine("==========================================================");

    //Shaker Sort
    int levy = 0;
    int pravy = n-1;

    while (levy < pravy) {
        for(int i = levy; i < pravy; i++)
        {
            if (myRandNumbs[i] < myRandNumbs[i + 1])
            {
                int tmp = myRandNumbs[i];
                myRandNumbs[i] = myRandNumbs[i + 1];
                myRandNumbs[i + 1] = tmp;
            }
        }
        pravy--;

        for(int i = pravy; i > levy; i--)
        {
            if(myRandNumbs[i] > myRandNumbs[i - 1])
            {
            int tmp = myRandNumbs[i];
            myRandNumbs[i] = myRandNumbs[i - 1];
            myRandNumbs[i - 1] = tmp;
            }        
        }
        levy++;
    }

    Console.WriteLine("Pole po seřazení algoritmem Shaker sort: ");
    for (int i = 0; i < n; i++)
        {
        Console.Write(myRandNumbs[i] + " ");
        }

    Console.WriteLine();
    Console.WriteLine("==========================================================");

// BUBBLE SORT
for (int i = 0; i < n - 1; i++) 
    {
    for (int j = 0; j < n - 1 - i; j++)
        {
        if (myRandNumbs[j] < myRandNumbs[j + 1])
        {
            int pomocna = myRandNumbs[j];
            myRandNumbs[j] = myRandNumbs[j + 1];
            myRandNumbs[j + 1] = pomocna;
        }
    }
}

//VYPIS BUBBLE SORTU
Console.WriteLine("Pole po seřazení algoritmem Bubble sort:");
for (int i = 0; i < n; i++)
{
    Console.Write(myRandNumbs[i]);
    if (i < n - 1)
    {
        Console.Write(" ");
    }
}
Console.WriteLine();
Console.WriteLine("==========================================================");






    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}
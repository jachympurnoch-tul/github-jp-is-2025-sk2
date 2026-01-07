using System;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("------- Generátor pseudonáhodných čísel ------");
    Console.WriteLine("-------------- TEST - Hlavní -----------------");
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("--------------- Jáchym Purnoch ---------------");
    Console.WriteLine("------------------ 6.1.2026 ------------------");
    Console.WriteLine("----------------------------------------------");

    // --- VSTUPY ---
    Console.Write("Zadejte počet generovaných čísel (n): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n) || n <= 0) Console.Write("Chyba, zadejte znovu: ");

    Console.Write("Zadejte dolní mez (dm): ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound)) Console.Write("Chyba, zadejte znovu: ");

    Console.Write("Zadejte horní mez (hm): ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound)) Console.Write("Chyba, zadejte znovu: ");

    // --- GENEROVÁNÍ ČÍSEL ---
    int[] myRandNumbs = new int[n];
    Random r = new Random();
    Console.Write("\nNáhodně vygenerovaná čísla jsou: ");
    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = r.Next(lowerBound, upperBound + 1);
        Console.Write(myRandNumbs[i] + (i < n - 1 ? ", " : ""));
    }
    Console.WriteLine("\n-----");

    // --- MAXIMUM, MINIMUM A POZICE ---
    int max = myRandNumbs[0];
    int min = myRandNumbs[0];
    for (int i = 0; i < n; i++)
    {
        if (myRandNumbs[i] > max) max = myRandNumbs[i];
        if (myRandNumbs[i] < min) min = myRandNumbs[i];
    }
    Console.Write("Maximum: " + max + ", pozice: ");
    for (int i = 0; i < n; i++) if (myRandNumbs[i] == max) Console.Write((i + 1) + "; ");
    Console.Write("\nMinimum: " + min + ", pozice: ");
    for (int i = 0; i < n; i++) if (myRandNumbs[i] == min) Console.Write((i + 1) + "; ");
    Console.WriteLine("\n-----");

    // --- BUBBLE SORT (Sestupně) ---
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - 1 - i; j++)
        {
            if (myRandNumbs[j] < myRandNumbs[j + 1])
            {
                int tmp = myRandNumbs[j];
                myRandNumbs[j] = myRandNumbs[j + 1];
                myRandNumbs[j + 1] = tmp;
            }
        }
    }
    Console.Write("Pole po seřazení: ");
    for (int i = 0; i < n; i++) Console.Write(myRandNumbs[i] + (i < n - 1 ? ", " : ""));
    Console.WriteLine("\n-----");

    // --- UNIKÁTNÍ NEJVĚTŠÍ ČÍSLA ---
    int druhe = int.MinValue, treti = int.MinValue, ctvrte = int.MinValue;
    foreach (int x in myRandNumbs)
    {
        if (x < max && druhe == int.MinValue) druhe = x;
        else if (x < druhe && treti == int.MinValue) treti = x;
        else if (x < treti && ctvrte == int.MinValue) ctvrte = x;
    }
    Console.WriteLine("Druhé největší číslo: " + (druhe == int.MinValue ? "N/A" : druhe.ToString()));
    Console.WriteLine("Třetí největší číslo: " + (treti == int.MinValue ? "N/A" : treti.ToString()));
    Console.WriteLine("Čtvrté největší číslo: " + (ctvrte == int.MinValue ? "N/A" : ctvrte.ToString()));

    // --- MEDIÁN ---
    int median = (n % 2 != 0) ? myRandNumbs[n / 2] : (myRandNumbs[(n / 2) - 1] + myRandNumbs[n / 2]) / 2;
    Console.WriteLine("Medián = " + median + "\n-----");

    // --- BINÁRNÍ PŘEVOD ---
    if (ctvrte != int.MinValue)
        Console.WriteLine("Čtvrté největší (" + ctvrte + ") binárně: " + Convert.ToString(ctvrte, 2));
    Console.WriteLine("-----");

    // --- OBRAZEC (KŘÍŽ) ---
    int vyska = median;
    int sirka = (treti != int.MinValue && treti > 0) ? treti : 5;
    int tloustka = (ctvrte > 0 && ctvrte < sirka) ? ctvrte : 1;

    // Korekce pro symetrii: Pokud je rozdíl mezi šířkou a tloušťkou lichý, 
    // zarovnání na střed by nebylo dokonalé. Upravíme tloustku.
    if ((sirka - tloustka) % 2 != 0 && tloustka < sirka) tloustka++;

    Console.WriteLine("Obrazec – výška = medián ({0}) ; šířka = třetí největší ({1})", vyska, sirka);
    Console.WriteLine();

    for (int i = 0; i < vyska; i++)
    {
        // Vodorovné břevno (střední část)
        // Podmínka i == vyska / 2 zajistí vykreslení zhruba uprostřed
        if (i == vyska / 2)
        {
            for (int j = 0; j < sirka; j++) Console.Write("* ");
        }
        else
        {
            // Svislá část (nožička)
            int pocetMezer = (sirka - tloustka) / 2;
            
            // Mezery zleva
            for (int j = 0; j < pocetMezer; j++) Console.Write("  "); 
            
            // Hvězdičky nožičky
            for (int j = 0; j < tloustka; j++) Console.Write("* ");
        }
        Console.WriteLine();
    }

    Console.WriteLine("\nPro opakování stiskněte 'a':");
    again = Console.ReadLine();
}
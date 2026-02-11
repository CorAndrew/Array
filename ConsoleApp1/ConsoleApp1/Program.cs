namespace Array1;

using System;
using static System.Console;

class Program
{
    static void Main()
    {
        // Lunghezza arbitraria array
        int[] array = new int[10];
        bool x;
        int n;

        // Caricamento array
        for (int i = 0; i < array.Length; i++)
        {
            do
            {
                WriteLine($"Inserisci il numero maggiore di 0:");
                x = int.TryParse(ReadLine(), out n);
            } while (!x || n < 0);

            array[i] = n;
        }

        bool duplicati = false;

        // Il ciclo che prende un elemento alla volta
        for (int i = 0; i < array.Length; i++)
        {
            // Il ciclo per controllare i numeri
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    duplicati = true;
                    break;
                }
            }
        }
        if (!duplicati)
        {
            WriteLine(1);
        }
        else
        {
            WriteLine(0);
        }
    }
}
namespace es2;

using System;
using static System.Console;

class Program
{
    static void Main()
    {
        int[] numeri = new int[30];
        Random generatore = new Random();

        WriteLine("Sequenza generata:");
        for (int i = 0; i < numeri.Length; i++)
        {
            numeri[i] = generatore.Next(0, 101); // Numeri tra 0 e 100
            Write(numeri[i] + " ");
        }

        WriteLine("Coppie trovate:");

        // Doppio ciclo for per confrontare ogni numero con tutti gli altri
        for (int i = 0; i < numeri.Length; i++)
        {
            for (int j = 0; j < numeri.Length; j++)
            {
                // Controllo numeri doppi e pari
                if (numeri[i] % 2 == 0 && numeri[i] == numeri[j] * 2)
                {
                    WriteLine($"{numeri[i]} / {numeri[j]}");
                }
            }
        }
    }
}
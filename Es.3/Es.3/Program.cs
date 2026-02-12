namespace Es3;

using System;
using static System.Console;

class Program
{
    static void Main()
    {
        float somma = 0;
        float[] vett = new float[100];
        bool x;
        float n;
        int contatore = 0;

        for (int i = 0; i < vett.Length; i++)
        {
            do
            {
                WriteLine($"Inserisci numero {i + 1}: ");
                x = float.TryParse(ReadLine(), out n);
                if (!x || n == 0) WriteLine("Errore: inserire un numero reale diverso da zero.");
            } while (!x || n == 0);

            vett[i] = n;
            somma += n;
            contatore++; // Incrementa il numero di elementi validi

            if (somma > 50)
            {
                WriteLine("Programma terminato");
                break;
            }
        }

        if (contatore >= 3)
        {
            float primoNumero = vett[0];
            bool trovata = false;

            for (int i = 0; i < contatore; i++)
            {
                for (int j = 0; j < contatore; j++)
                {
                    // Calcolo del rapporto tra il numero in poszione i e il numero in j
                    if ((vett[i] / vett[j]) == primoNumero)
                    {
                        WriteLine($"{vett[i]} / {vett[j]}");
                        trovata = true;
                    }
                }
            }

            if (!trovata)
            {
                WriteLine("Nessuna coppia soddisfa la condizione.");
            }
        }
        else
        {
            WriteLine("Hai inserito meno di 3 numeri");
        }
    }
}
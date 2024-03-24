using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ile liczb będziesz chciał posortować? ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] tab = new int[n];

        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            tab[i] = random.Next(1, 1000); // Liczby od 1 do 1000
        }

        Console.WriteLine("Tablica przed sortowaniem:");
        foreach (var item in tab)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        SortowanieBabulkowe(tab, n);

        Console.WriteLine("Tablica po sortowaniu:");
        foreach (var item in tab)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void SortowanieBabulkowe(int[] tab, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j < n - i; j++)
            {
                if (tab[j - 1] > tab[j])
                {
                    // Zamiana miejscami
                    int temp = tab[j - 1];
                    tab[j - 1] = tab[j];
                    tab[j] = temp;
                }
            }
        }
    }
}

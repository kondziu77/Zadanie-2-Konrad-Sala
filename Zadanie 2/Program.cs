using System;

class SortowanieLiczb
{
    private int[] liczby = new int[6];

    public void read_data()
    {
        Console.WriteLine("Wprowadź 6 liczb do posortowania:");
        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Liczba {i + 1}: ");
            liczby[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    public void process_data()
    {
        Array.Sort(liczby);
    }

    public void show_results()
    {
        Console.WriteLine("Posortowane liczby:");
        foreach (int liczba in liczby)
        {
            Console.Write(liczba + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        SortowanieLiczb sortowanie = new SortowanieLiczb();

        sortowanie.read_data();
        sortowanie.process_data();
        sortowanie.show_results();
    }
}
// Console template
using System;
class Program
{
    static void Main()
    {
        Console.Clear();
        Console.Write("Input string: ");
        string key = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Input limit: ");
        string limittemp = Console.ReadLine();
        int limit = Convert.ToInt32(limittemp);

        HashAlgorithm(key, limit);
    }

    static int HashAlgorithm(string key, int limit)
    {
        Console.WriteLine(key);
        Console.WriteLine(limit);
        int total = 0;
        foreach (char c in key)
        {
            total += Convert.ToInt32(c);
        }

        total = total*total;
        Console.WriteLine(total);
        string digits = "";
        digits += total[(total.Length())/2];
        Console.WriteLine(digits);



        int hash = 0;
        return hash;
    }
}

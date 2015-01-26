using System;
using System.Collections.Generic;

class SortASequence
{
    static void Main()
    {
        int num = Int32.Parse(Console.ReadLine());
        List<int> numbers = new List <int> ();
        int next = new int();
        for (int i = 0; i < num; i++)
        {
            next = Int32.Parse(Console.ReadLine());
            numbers.Add(next);
        }
        numbers.Sort();
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}


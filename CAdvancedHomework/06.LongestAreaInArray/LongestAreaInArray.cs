using System;
using System.Collections.Generic;

class LongestAreaInArray
{
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        Dictionary<string, int> words = new Dictionary<string, int>();
       
        for (int i = 0; i < n; i++)
        {
            string str = Console.ReadLine();
            if (words.ContainsKey(str))
            {
                words[str] = words[str] + 1;
            }
            else
            {
                words[str] = 1;
            }
        }

        int compare = 0;
        string word = null;
        int longestValue = 1;

        foreach (var pair in words)
        {
            if (pair.Value > compare)
            {
                compare = pair.Value;
                  word = pair.Key;
                  longestValue = pair.Value;
            }
           // Console.WriteLine(pair.Key + " -> " + pair.Value);
        }

        Console.WriteLine();
        Console.WriteLine("{0}",longestValue);
        for (int i = 0; i < longestValue; i++)
        {
             Console.WriteLine(word);
        }
    }
}


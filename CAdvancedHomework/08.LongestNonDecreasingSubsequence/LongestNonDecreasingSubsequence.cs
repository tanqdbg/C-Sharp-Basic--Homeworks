using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LongestNonDecreasingSubsequence
{
    static void Main()
    {
        //Write a program that reads a sequence of integers and finds in it the longest non-decreasing subsequence.
        // In other words, you should remove a minimal number of numbers from the starting sequence,
        //so that the resulting sequence is non-decreasing. In case of several longest non-decreasing sequences, 
        //print the leftmost of them. The input and output should consist of a single line, holding integer numbers separated by a space. Examples:
        //// 7 3 5 8 -1 6 7 // 3 5 6 7
        //
        //
        Console.WriteLine("Enter a sequence of integers on a line, separated by a space:");
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[input.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            int n;
            bool nParse = int.TryParse(input[i], out n);
            if (!nParse)
            {
                Console.WriteLine("invalid input");
                return;
            }
            numbers[i] = n;
        }
        List<int> allNonDecreasing = new List<int>();
        List<int> longest = new List<int>();
        string output = Convert.ToString(numbers[0]);
        int max = 1;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            allNonDecreasing.Add(numbers[i]);
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] <= numbers[j])
                {
                    allNonDecreasing.Add(numbers[j]);
                }
            }
            int allVariations = (int)Math.Pow(2, allNonDecreasing.Count) - 1;
            while (allVariations > 0)
            {
                longest.Add(numbers[i]);
                for (int j = 1; j < allNonDecreasing.Count; j++)
                {
                    if (allNonDecreasing[j] >= longest.Last() && (((allVariations >> allNonDecreasing.Count - j) & 1) == 1 ))
                    //(((allVariations >> allNonDecreasing.Count - j) & 1) == 1 )) - ne mi e qsno kakvo stava tuka!!
                    {
                        longest.Add(allNonDecreasing[j]);
                    }
                }
                if (longest.Count > max)
                {
                    output = string.Join(" ", longest);
                    max = longest.Count;
                }
                allVariations--;
                longest.Clear();
            }
            allNonDecreasing.Clear();
        }
        Console.WriteLine(output);
    }
}


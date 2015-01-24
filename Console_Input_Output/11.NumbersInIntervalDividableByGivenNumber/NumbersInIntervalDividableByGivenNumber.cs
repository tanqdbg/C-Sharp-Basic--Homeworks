using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main(string[] args)
    {
        //Write a program that reads two positive integer numbers and prints how many numbers p exist between them
        // such that the reminder of the division by 5 is 0. Examples
        int start = Int32.Parse(Console.ReadLine());
        int end = Int32.Parse(Console.ReadLine());
        int p = 0;
        if (end<start)
        {
            int bufer = start;
            start = end;
            end = bufer;
        }
        for (int i = start; i <= end; i++)
			{
                if (i % 10 == 0 || i % 10 == 5)
                {
                    p++;
                 }
			}
        Console.WriteLine(p);
    }
}


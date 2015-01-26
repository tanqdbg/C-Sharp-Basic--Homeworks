using System;
using System.Linq;
using System.Collections.Generic;

class playLast2014
{
    static void Main()
    {
        string [] inpput = Console.ReadLine().Split(new char[]{' '}, 
        StringSplitOptions.RemoveEmptyEntries);

        List<decimal> even = new List<decimal>();
        List<decimal> odd = new List<decimal>();
    
        for (int i = 0; i < inpput.Length; i ++)
        {
            decimal element = decimal.Parse(inpput[i]);
            if (i%2==0)
            {
                odd.Add(element);
            }
            else
            {
                even.Add(element);
            }
        }
        foreach (var element in even)
        {

            decimal BestSummEven = (element + (element + 1.00m));
        }
        if (odd.Count <= 0)
        {
            Console.Write("OddSum=No, OddMin=No, OddMax=No, ");
        }
        else
        {
            Console.Write("OddSum={0}, OddMin={1}, OddMax={2}, ", (double)odd.Sum(), (double)odd.Min(), (double)odd.Max());
        }
        if (even.Count <= 0)
        {
            Console.Write("EvenSum=No, EvenMin=No, EvenMax=No");
        }
        else
        {
            Console.Write("EvenSum={0}, EvenMin={1}, EvenMax={2}", (double)even.Sum(), (double)even.Min(), (double)even.Max());
        }

    }
}


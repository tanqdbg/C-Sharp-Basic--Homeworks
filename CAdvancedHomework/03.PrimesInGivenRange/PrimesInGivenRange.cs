using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    public static bool IsPrime(double number)
    {
        bool prime = true;
        double maxDevider = (Math.Sqrt(number));
        if (number < 2)
        {
            prime = false;
        }
        if (number > 1)
        {
            for (int i = 2; i <= maxDevider; i++)
            {
                if (number % i == 0)
                {
                    prime = false;
                }
            }
        }
        return prime;
    }

    static void Main()
    {
        double min = double.Parse(Console.ReadLine());
        double max = double.Parse(Console.ReadLine());
        List<double> primeNumbers = new List<double>();

        for (double i = min; i <= max; i++)
        {
            bool prime = IsPrime(i);
            if (prime == true)
            {
                primeNumbers.Add(i);
            }
        }
        foreach (var item in primeNumbers)
        {
            Console.Write(string.Join(",",item));
            //Console.WriteLine("{0} ", item);
        }
    }
}


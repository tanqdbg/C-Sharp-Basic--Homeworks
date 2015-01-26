using System;
using System.Numerics;

class PrimeChecker
{
    static void Main()
    {
       double num = double.Parse(Console.ReadLine());
       Console.WriteLine(IsPrime(num)); 
    }

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
            for (int i = 2; i <=maxDevider; i++)
            {
                if (number % i == 0)
                {
                    prime = false;
                    break;
                }
            }
        }
        return prime;
    }
}


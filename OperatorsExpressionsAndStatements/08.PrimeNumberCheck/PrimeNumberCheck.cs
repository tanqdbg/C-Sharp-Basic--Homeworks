using System;

class PrimeNumberCheck

{
    static void Main(string[] args)
    {
        int number = Int32.Parse(Console.ReadLine());
        bool isPrime = false;
        int count = 0;
        if (number <=0||number==1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
        }
        if (count == 0)
        {
            isPrime = true;
        }
        Console.WriteLine(isPrime);
        
    }
}

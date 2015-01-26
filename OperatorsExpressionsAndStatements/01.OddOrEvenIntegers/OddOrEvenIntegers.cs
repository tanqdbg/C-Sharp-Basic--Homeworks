using System;

class OddOrEvenIntegers
{
    static void Main(string[] args)
    {
        int number = Int32.Parse(Console.ReadLine());

        if (number%2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
}


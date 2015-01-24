using System;

class FibonacciNumbers
{
    static void Main(string[] args)
    {
        //Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
        //(at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
        //Note that you may need to learn how to use loops
        int n = Int32.Parse(Console.ReadLine());
        Console.WriteLine();
        int num1 = 0;
        int num2 = 1;
        int num3 = 1;
        if (n==1)
        {
            Console.WriteLine(num1); 
        }
        else if (num1==2)
        {
            Console.Write("{0} {1}",num1,num2);
        }
        else
        {
            Console.Write("0 1 ");
            for (int i = 2; i < n; i++)
            {
                num3 = num1 + num2;
                Console.Write("{0} ", num3);
                num1 = num2;
                num2 = num3;
            }
           
        }
       
    }
}


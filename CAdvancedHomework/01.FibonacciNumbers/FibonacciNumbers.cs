using System;
using System.Collections.Generic;

class FibonacciNumbers
{
    static void Main(string[] args)
    {
        int num = Int32.Parse(Console.ReadLine());
        FibonachiNum(num);

    }

    private static void FibonachiNum(int number)
    {
        long firstNum = 1;
        long secondNum = 1;
        long fibNumber = 0;

        if ((number==1)||(number==0))
	    {
		     Console.WriteLine(1);
	    }
        if (number<1)
	    {
		     Console.WriteLine("WrongNumber");
	    }
        if (number>1)
	    {
            for (int i = 2; i <= number; i++)
            {
                fibNumber = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = fibNumber;
            }

            Console.WriteLine(fibNumber);
	    }
        
    }
}


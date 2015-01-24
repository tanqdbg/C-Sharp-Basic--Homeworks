using System;

class SummOfThreeNumbers
{
    static void Main(string[] args)
    {
        //Write a program that reads 3 real numbers from the console and prints their sum
        string num;
        float numToFloat = 0;
        float summ = 0;
        for (int i = 0; i < 3; i++)
			{
               num = Console.ReadLine();
                if (float.TryParse(num, out numToFloat))
                {
                    summ = summ + numToFloat;
                }
                else
                {
                    Console.WriteLine("Ops! {0} = 0!", num);
                } 
            }
                Console.Write("summ is: ");
                Console.WriteLine(summ);
    }
}


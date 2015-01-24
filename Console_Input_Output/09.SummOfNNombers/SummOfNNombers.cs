using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class SummOfNNombers
{
    static void Main(string[] args)
    {
        //Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
        //Note that you may need to use a for-loop
        int n = Int32.Parse(Console.ReadLine());
        double num = 0;
        double summ = 0;
        for (int i = 0; i < n; i++)
        {
            num = Double.Parse(Console.ReadLine());
            summ = summ + num;

        }
        Console.WriteLine();
        Console.WriteLine("summ = {0}",summ);
    }
}

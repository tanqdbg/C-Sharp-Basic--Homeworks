using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.NumbersFromOneToTen
{
    class NumbersFromOneToTen
    {
        static void Main(string[] args)
        {
            //Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n],
            //each on a single line. Note that you may need to use a for-loop
            int n = Int32.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0} ",i);
            }

        }

    }
}

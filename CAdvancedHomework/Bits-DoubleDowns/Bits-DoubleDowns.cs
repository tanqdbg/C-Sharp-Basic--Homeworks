using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bits_DoubleDowns
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int left = 0;
            int right = 0;
            int vertical = 0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                int n1 = numbers[i];
                int n2 = numbers[i + 1];

                for (int j = 0; j < 32; j++)
                {
                    int z ;
                    bool hb = ((z = (n1 >> j) & 1)==1);
                    bool hbl = ((z = (n2 >> j + 1) & 1) == 1);
                    bool hbr = ((z = (n2 >> j - 1) & 1) == 1);
                    bool hbv = ((z =(n2 >> j) & 1) == 1);
                    if (hb  && hbl)
                    {
                        left++;
                    }
                    if (hb && hbr)
                    {
                        right++;
                    }
                    if (hb && hbv)
                    {
                        vertical++;
                    }
                }
            }
            Console.WriteLine(right);
            Console.WriteLine(left);
            Console.WriteLine(vertical);
        }
    }
}

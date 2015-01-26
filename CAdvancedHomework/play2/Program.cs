using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBuilder
{
    class BitBuilder
    {
        static void Main(string[] args)
        {
            int n = 963;// int.Parse(Console.ReadLine());
            Console.WriteLine("n = {0,2}",Convert.ToString(n,2));
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "quit")
                {
                    break;
                }
                int a = int.Parse(input);
                string order = Console.ReadLine();

                switch (order)
                {
                    case "flip":
                        n = FlipBit(n, a);
                        break;
                    case "insert":
                        n = InsertBit(n, a);
                        break;
                    case "remove":
                        n = RemoveBit(n, a);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(n);
        }
    
        static int RemoveBit(int n, int a)
        {
            Console.WriteLine("RemoveBit");
            int result = 0;
            int addition = 0;
            for (int i = 0; i < 12; i++)
            {
                                                                                      Console.WriteLine("i = {0}",i);
                int mask = 1 << i;
                                                                               Console.WriteLine("mask = {0:f2}",Convert.ToString(mask,2));
                 if (i == a)
                {
                    addition = 1;
                    continue;
                    Console.WriteLine();
                }
                                                                      int nIMask = (n & mask);
                                                                      Console.WriteLine("n =    {0,2}", Convert.ToString(n, 2));
                                                                                     Console.WriteLine("(n & mask) = {0:f2}", Convert.ToString(nIMask,2));
                result += (n & mask) >> addition;
                                                                             Console.WriteLine("result = {0:f2}", Convert.ToString(result, 2));
                                                                             Console.WriteLine();
            }
            return result;
        }

        static int InsertBit(int n, int a)
        {
            int result = 0;
            int addition = 0;
            for (int i = 0; i < 32; i++)
            {

                int mask = 1 << i;
                if (i == a)
                {
                    result += 1 << i;
                    addition = 1;
                }
                result += (n & mask) << addition;
            }
            return result;
        }

        static int FlipBit(int n, int a)
        {
            int mask = 1 << a;

            int bit = mask & n;
            if (bit == 1)
            {
                n = n & ~mask;
            }
            else
            {
                n = n | mask;
            }
            return n;
        }
    }
}

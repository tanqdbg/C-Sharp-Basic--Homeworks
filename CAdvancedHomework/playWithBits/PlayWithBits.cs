using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playWithBits
{
    class PlayWithBits
    {
        static void Main(string[] args)
        {
                int num = int.Parse(Console.ReadLine());
                int result = 0;
                while (num>0)
                {
                    int lastBit = num & 1;
                                                                                    Console.WriteLine("lastBit = {0:f2}", Convert.ToString(lastBit, 2));
                    num = num >> 1;
                                                                         Console.WriteLine("num = {0:f2}", Convert.ToString(num, 2));
                    result = result << 1;
                                                                          Console.WriteLine("result = {0:f2}", Convert.ToString(result, 2));
                    result = result | lastBit;
                                                                           Console.WriteLine("result = {0:f2}", Convert.ToString(result, 2));
                                                                              Console.WriteLine();

                }
                Console.WriteLine("result = {0:f2}", Convert.ToString(result, 2));
        }
    }
}

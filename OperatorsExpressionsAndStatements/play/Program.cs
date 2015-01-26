using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modify_a_Bit_at_Given_Position
{
    class ModifyABitAtGivenPosition
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
            if (v == 0)
            {
                n = n & ~(1 << p);
            }
            else
            {
                n = n | (1 << p);
            }
            Console.WriteLine(n);
        }
    }
}

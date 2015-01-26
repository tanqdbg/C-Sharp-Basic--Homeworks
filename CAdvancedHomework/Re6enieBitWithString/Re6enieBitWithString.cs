using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Re6enieBitWithString
{
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        int position = Int32.Parse(Console.ReadLine());
        int r = Int32.Parse(Console.ReadLine());
        char[] bits = Convert.ToString(n,2).PadLeft(19,'0').ToCharArray();
        int num = 0; ;
        char[] newBit = new char[bits.Length];
        position = 19 - 1 - position;
        for (int i = 0; i < r; i++)
        {
            for (int pos = 0; pos < bits.Length; pos++)
            {
                if (pos == position-1)
                {
                    newBit[pos+2] = bits[pos];
                }
                else if (pos == position)
                {
                    newBit[pos] = bits[pos];
                }
                else if (pos == 18)
                {
                    newBit[0] = bits[pos];
                }
                else
                {
                    newBit[pos + 1] = bits[pos];
                }
            }
            for (int j = 0; j < newBit.Length; j++)
            {
                bits[j] = newBit[j];
                Console.Write(bits[j]);
            }
            Console.WriteLine();
        }
        num = Convert.ToInt32(new string(newBit), 2);
        Console.WriteLine(num);
    }
}


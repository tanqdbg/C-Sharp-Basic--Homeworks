using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Exchange__Advanced_
{
    class BitExchangeAdvanced
    {
        static void Main()
        {
            try
            {
                uint n = uint.Parse(Console.ReadLine());
                int p = int.Parse(Console.ReadLine());
                int q = int.Parse(Console.ReadLine());
                int k = int.Parse(Console.ReadLine());
                if (Math.Max(p, q) + k - 1 > 31)
                {
                    Console.WriteLine("Out of range!");
                }
                else if (Math.Min(p, q) + k - 1 >= Math.Max(p, q))
                {
                    Console.WriteLine("Overlapping!");
                }
                else
                {
                    for (int i = p; i <= p + k - 1; i++)
                    {
                        uint mask = 1;
                        uint bitQ = (n & (mask << q)) >> q; //взимаме бита от позиция q
                        uint bitP = (n & (mask << i)) >> i; //взимаме бита от позиция p
                        n = n & ~(mask << i); // на позиция р слагаме нуличка
                        n = n & ~(mask << q); // на позиция q слагаме нуличка
                        n = n | (bitP << q); // на позиция q слагаме бита от р
                        n = n | (bitQ << i);// на позиция р слагаме бита от q
                        q++;                // добавяме единица към q за да хванем следвашия q бит (q+1)
                    }
                    Console.WriteLine(n);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Out of range!");
            }
            }
    }
}
// друго решение 
//using System;

//class BitsExchange
//{
//    static void Main()
//    {
//        //Console.Write("number ");
//        uint number = 987654321; //uint.Parse(Console.ReadLine());
//        Console.WriteLine(number);
//        uint newNumber = 0;
//        int p = 2;// Int32.Parse(Console.ReadLine());
//        int q = 8;// Int32.Parse(Console.ReadLine());
//        int k = 11;// Int32.Parse(Console.ReadLine());
//        int diff;
//        int smaller;
//        uint maxValue = uint.MaxValue;
//        bool checkOverlap = false;
//        if (number >= maxValue || p<0 || q<0)
//        {
//            Console.WriteLine("out of range");
//        }
//        if (p > q)
//        {
//            diff = p - q;
//            smaller = q;
//        }
//        else
//        {
//            diff = q - p;
//            smaller = p;
//        }
//        if ( (smaller + diff + k) > 32 )
//        {
//            Console.WriteLine("out of range");
//        }
//        else
//        {

//            for (int i = 0; i <= 64; i++)
//            {
//                if ((i >= smaller) && (i <= (smaller + k - 1)))
//                {
//                    newNumber = ExchangeBitPositions(number, p, q);
//                    if (newNumber < number)
//                    {
//                        checkOverlap = true;
//                    }
//                    number = newNumber;
//                    p++;
//                    q++;
//                }
//            }
//            if (checkOverlap == true)
//            {
//                Console.WriteLine("overlap");
//            }
//            else
//            {
//                Console.WriteLine(newNumber);
//            }
//            Console.WriteLine();
//        }
//    }
//    static uint ExchangeBitPositions(uint number, int position, int newPosition)
//    {
//        uint firstChange;
//        uint newNumber = 0;
//        uint checkPosition = ((number >> position) & 1);
//        uint checkNewPosition = ((number >> newPosition) & 1);
//        if (checkPosition == checkNewPosition)
//        {
//            newNumber = number;
//            return newNumber;
//        }
//        if (checkPosition == 1 && checkNewPosition == 0)
//        {
//            firstChange = (uint)(number & (~(1 << position)));
//            newNumber = (uint)(firstChange | (1 << newPosition));
//            return newNumber;
//        }
//        if (checkPosition == 0 && checkNewPosition == 1)
//        {
//            firstChange = (uint)(number | (1 << position));
//            newNumber = (uint)(firstChange & (~(1 << newPosition)));
//            return newNumber;
//        }
//        else
//        {
//            return newNumber;
//        }
//    }
//}
        

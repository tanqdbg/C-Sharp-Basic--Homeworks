using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("number ");
        uint number = uint.Parse(Console.ReadLine());
        uint newNumber = ExchangeBitPositions(ExchangeBitPositions(ExchangeBitPositions(number, 3, 24), 4, 25), 5, 26);
        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(32, '0'));
        Console.WriteLine(newNumber);
    }

    static uint ExchangeBitPositions(uint number, int position, int newPosition)
    {
        uint firstChange;
        uint newNumber = 0;
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        uint checkPosition = ((number >> position) & 1);
        uint checkNewPosition = ((number >> newPosition) & 1);


        if (checkPosition == checkNewPosition)
        {
            newNumber = number;
            return newNumber;
        }
        if (checkPosition == 1 && checkNewPosition == 0)
        {
            firstChange = (uint)(number & (~(1 << position)));
            newNumber = (uint)(firstChange | (1 << newPosition));
            return newNumber;
        }
        if (checkPosition == 0 && checkNewPosition == 1)
        {
            firstChange = (uint)(number | (1 << position));
            newNumber = (uint)(firstChange & (~(1 << newPosition)));
            return newNumber;
        }
        else
        {
            return newNumber;
        }
    }
    
}
    //Друго решение - по ясно!!!

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BitsExchange
//{
//    class BitsExchange
//    {
//        static void Main()
//        {
//            uint n = uint.Parse(Console.ReadLine());
//            uint mask = 7;
//            uint firstBits = (n & (mask << 3))>>3;
//            uint secondBits = (n & (mask << 24)) >> 24;
//            n = n & ~(mask << 3);
//            n = n & ~(mask >> 24);
//            n = n | (firstBits << 24);
//            n = n | (secondBits << 3);
//            Console.WriteLine(n);
//        }
//    }
//}

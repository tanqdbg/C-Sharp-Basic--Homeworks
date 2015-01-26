using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        int number = Int32.Parse(Console.ReadLine());
        int position = Int32.Parse(Console.ReadLine());
        int bit = ((number>>position)&1);
        bool isOne = (bit == 1);
        Console.WriteLine(Convert.ToString(number,2));
        Console.WriteLine(isOne);
    }
}
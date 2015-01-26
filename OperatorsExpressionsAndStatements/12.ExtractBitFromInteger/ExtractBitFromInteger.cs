using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        int number = Int32.Parse(Console.ReadLine());
        int pozition = Int32.Parse(Console.ReadLine());
        int bit = ((number>>pozition)&1);
        Console.WriteLine(Convert.ToString(number,2).PadLeft(16,'0'));
        Console.WriteLine(bit);

    }
}
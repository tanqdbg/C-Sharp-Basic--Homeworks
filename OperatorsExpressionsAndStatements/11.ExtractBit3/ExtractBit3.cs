using System;

class ExtractBit3
{
    static void Main()
    {
        int number = Int32.Parse(Console.ReadLine());
        int poziciq = (number>>3);
        int bit = (1 & poziciq);
        Console.WriteLine(Convert.ToString(number,2).PadLeft(16,'0'));
        Console.WriteLine(bit);
    }
}
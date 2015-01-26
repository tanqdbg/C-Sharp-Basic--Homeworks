using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("number ");
        int number = Int32.Parse(Console.ReadLine());
        Console.Write("position ");
        int position = Int32.Parse(Console.ReadLine());
        Console.Write("to be ");
        int v = Int32.Parse(Console.ReadLine());
        int checkv = ((number>>position)&1);
        int newValue;
        int maskWithOnes = (1 << position);
        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
        //Console.WriteLine(checkv);
        //Console.WriteLine(Convert.ToString(maskWithOnes, 2).PadLeft(16, '0'));
        //Console.WriteLine(Convert.ToString(~maskWithOnes, 2).PadLeft(16, '0'));
        Console.Write("Result is ");

        if (checkv == v)
        {
            Console.WriteLine(number);
        }
        else if (checkv == 1 && v == 0)
        {
            newValue = (~ maskWithOnes & number);
            Console.WriteLine(newValue);
        }
        else if (checkv == 0 && v == 1)
        {
            newValue = (maskWithOnes | number);
            Console.WriteLine(newValue);
        }
        else
        {
            Console.WriteLine("Wrong value for \"v\"");
        }
    }
}

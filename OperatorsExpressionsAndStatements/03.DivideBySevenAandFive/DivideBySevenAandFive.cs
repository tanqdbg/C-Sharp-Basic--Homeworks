using System;

class DivideBySevenAandFive
{
    static void Main(string[] args)
    {
        int number = Int16.Parse(Console.ReadLine());
        bool devideble = false;
        if ((number % 5 == 0) && (number % 7== 0))
        {
            devideble = true;
        }
        Console.WriteLine(devideble);
        Console.WriteLine();
    }
}


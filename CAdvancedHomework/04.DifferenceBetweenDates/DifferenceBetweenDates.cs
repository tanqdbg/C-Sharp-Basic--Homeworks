using System;
using System.Linq;

class DifferenceBetweenDates
{
    static void Main()
    {
        DateTime dataFirst = DateTime.Parse(Console.ReadLine());
        DateTime dataSecond = DateTime.Parse(Console.ReadLine());
        double days = (dataSecond - dataFirst).TotalDays;
        Console.WriteLine(days);


    }
}


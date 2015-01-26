using System;

class PointIinACircle
{
    static void Main(string[] args)
    {
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());

        bool isInside = (x * x) + (y * y) <= (2 * 2);

        Console.WriteLine("These coordinates are inside the circle = " + isInside);
    }
}
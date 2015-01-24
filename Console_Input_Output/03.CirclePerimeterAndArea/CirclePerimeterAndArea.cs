using System;

class CirclePerimeterAndArea
{
    static void Main(string[] args)
    {
        //Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
        double r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("area = {0:0.00}", (3.14159 * r * r));
        Console.WriteLine("perimeter = {0:0.00}", (2 * 3.14159 * r));
    }
}

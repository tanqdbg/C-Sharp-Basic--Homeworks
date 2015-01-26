using System;
//using System.Linq;

class PointInsideCircleAndOutsideRectangle
{
    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool inSircle =((Math.Pow(x-1, 2) + Math.Pow(y-1, 2)) <= Math.Pow(1.5, 2));
        bool outRectangle = !((-1 >= x || x <= 5) && (-1 >= y || y <= 1 ));
        if (inSircle && outRectangle == true)
            {
                 Console.WriteLine("Yes");
            }
        else

            {
                Console.WriteLine("No");
            }
        Console.WriteLine();                            
    }
}
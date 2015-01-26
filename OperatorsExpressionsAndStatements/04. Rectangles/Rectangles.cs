using System;

class Rectangles
{
    static void Main(string[] args)
    {
        float width = float.Parse(Console.ReadLine());
        float height = float.Parse(Console.ReadLine());

        float perimeter = (2 * width + 2 * height);
        float area = (width * height);
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
        Console.WriteLine();
    }
}



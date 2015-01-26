using System;

class GravitationOnTheMoon
{
    static void Main(string[] args)
    {
        float weightEarth = float.Parse(Console.ReadLine());
        float weightMoon = ((weightEarth * 17) / 100);
        Console.WriteLine(weightMoon);
    }
}


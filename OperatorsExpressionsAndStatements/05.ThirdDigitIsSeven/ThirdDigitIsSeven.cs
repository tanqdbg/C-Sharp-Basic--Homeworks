using System;

class ThirdDigitIsSeven
{
    static void Main(string[] args)
    {
        int number = Int32.Parse(Console.ReadLine());
        bool isSeven = false;
        if (((number/10)/10)%10==7)
        {
            isSeven = true;
        }
        Console.WriteLine(isSeven);
    }
}

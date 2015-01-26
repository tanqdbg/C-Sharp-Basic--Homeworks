using System;

class FourDigitNumber
{
    static void Main(string[] args)
    {
        int number = Int32.Parse(Console.ReadLine());
        int d = number % 10;
        int c = (number/10)%10;
        int b = ((number / 10)/10) % 10;
        int a = (((number / 10) / 10)/10) % 10;
        Console.WriteLine("{0}",a+b+c+d);
        Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
    }
}
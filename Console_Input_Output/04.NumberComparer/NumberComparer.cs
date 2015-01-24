using System;

class NumberComparer
{
    static void Main(string[] args)
    {
        //Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements
        
        float num1 = float.Parse(Console.ReadLine());
        float num2 = float.Parse(Console.ReadLine());
        
        Console.WriteLine(Math.Max(num1,num2));
    }
}


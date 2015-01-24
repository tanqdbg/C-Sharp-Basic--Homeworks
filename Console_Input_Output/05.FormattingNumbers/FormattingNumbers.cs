﻿using System;

class FormattingNumbers
{
    static void Main(string[] args)
    {
        //Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c 
        //and prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. 
        //The number a should be printed in hexadecimal, left aligned;
        //then the number a should be printed in binary form, padded with zeroes,
        //then the number b should be printed with 2 digits after the decimal point, right aligned;
        //the number c should be printed with 3 digits after the decimal point, left aligned. 
        int a = Int16.Parse(Console.ReadLine());
        if (0>a && a>500)
        {
            Console.WriteLine("a out of range");
        }
        else
        {
            float b = Convert.ToSingle(Console.ReadLine());
            float c = Convert.ToSingle(Console.ReadLine());
            //Console.Write("|{0,-10:X}|", a);// може и по този начин ->  Console.Write("|{0,-10}|", a.ToString("X"));
            Console.Write("|{0,-10}|", a.ToString("X"));
            Console.Write(Convert.ToString(a,2).PadLeft(10,'0'));
            Console.Write("|{0,10:0.00}", b);
            Console.Write("|{0,-10:0.000}|", c);
            Console.WriteLine();

        }
    }
}


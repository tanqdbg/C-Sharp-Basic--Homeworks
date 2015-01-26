using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class examSoftUni
{
    static void Main()
    {
       // Console.OutputEncoding = Encoding.Unicode;
        int numSystem =Int32.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int lenght = input.Length;
        int totalValue = 0;
        for (int i = 0; i < input.Length; i++)
        {
            char letter = input[i];
            int value = (int)input[i];
            if ((value >= 97 && value <= 122) || (value >= 65 && value <= 90))
            {
                value = LettersValueCount(letter);
            }
            //Console.Write(input[i]+ "-" + value);
            //Console.WriteLine();
            totalValue += value;
        }
        //output
        Console.WriteLine("{0}{1}{2}", numSystem, lenght, NumeralSystemConvertor(totalValue, numSystem));
    }

    static string NumeralSystemConvertor(int totalValue,int numeralSystem)
    {
        string converValue = "";
        while (totalValue>0)
        {
            converValue += (totalValue % numeralSystem);
            totalValue /= numeralSystem;
        }
        string converValueReversed = "";
        for (int i = converValue.Length-1; i >= 0; i--)
        {
            converValueReversed += converValue[i];
        }
        converValue = converValueReversed;
        return converValue;
    }
    static int LettersValueCount(char letter)
    {
        Dictionary <char,int>lettersValue = new Dictionary<char,int>()  { 
        {'a', 1}, {'b', 2},{'c', 3},{'d', 4},{'e', 5},{'f', 6},{'g', 7},{'h', 8},{'i', 9},{'j', 10},
        {'k', 11},{'l', 12},{'m', 13},{'n', 14},{'o', 15},{'p', 16},{'q', 17},{'r', 18},{'s', 19},{'t', 20},
        {'u', 21},{'v', 22},{'w', 23},{'x', 24},{'y', 25},{'z', 26},
        {'A', 1}, {'B', 2},{'C', 3},{'D', 4},{'E', 5},{'F', 6},{'G', 7},{'H', 8},{'I', 9},{'J', 10},
        {'K', 11},{'L', 12},{'M', 13},{'N', 14},{'O', 15},{'P', 16},{'Q', 17},{'R', 18},{'S', 19},{'T', 20},
        {'U', 21},{'V', 22},{'W', 23},{'X', 24},{'Y', 25},{'Z', 26} 
        };
        int value = 0;
        for (int i = 0; i < lettersValue.Count; i++)
			{
			 value = lettersValue[letter];
			}
        return value;         
    }
}

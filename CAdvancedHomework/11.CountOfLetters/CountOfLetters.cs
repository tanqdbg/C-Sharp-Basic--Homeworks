using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CountOfLetters
{
    class CountOfLetters
    {
        static void Main()
        {
            List<char> charList = new List<char>() {'h','d','h','a','a','a','s','d','f','d','a','d','j','d','s','h','a','a'};
            charList.Sort();
            char lastchar = charList.First();
            int counter = 0;
            foreach (var item in charList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var ch in charList)
            {
                if (ch==lastchar)
                {
                    counter++;
                }
                else
                {
                    Console.Write(lastchar + " -> " +"{0}",counter);
                    Console.WriteLine();
                    lastchar = ch;
                    counter = 1;
                }
            }
                Console.Write(lastchar + " -> " +"{0}",counter);
                Console.WriteLine();
        }
    }
}
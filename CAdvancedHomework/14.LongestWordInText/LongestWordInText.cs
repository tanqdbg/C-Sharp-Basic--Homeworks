using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.LongestWordInText
{
    class LongestWordInText
    {
        static void Main()
        {
            //string text = "Welcome to the Software University.";
            //List<string> words = new List<string>();
            //words = string.Split
            //    (new char[]{' ',',', '.'},            );

            int n = 7;// Int32.Parse(Console.ReadLine());  
            string dot = new string('.',n);
            string spase = new string(' ',n);
            char star = '*';

            string row = "";
            for (int i = 0; i < n; i++)
            {
                dot = new string('.', n/2+i);
                spase = new string( ' ',n - i );
                row = (spase + star + dot + star + dot + star);
                int r = Convert.ToInt32(i);
                Console.WriteLine(row);

            }
        }
    }
}

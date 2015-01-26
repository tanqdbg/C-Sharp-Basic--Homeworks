using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessQueens
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;// Int32.Parse(Console.ReadLine());
            char[] bukvi = new char[n];

            for (int i = 0; i < n; i++)
            {
                bukvi[i] = (char)('a' + i);
            }
            
            for (int i = 0; i < bukvi.Length; i++)
            {
                Console.Write("{0} ",bukvi[i]);
                int num = (int)bukvi[i];
                Console.WriteLine("{0} ",num);
            }



        }
    }
}

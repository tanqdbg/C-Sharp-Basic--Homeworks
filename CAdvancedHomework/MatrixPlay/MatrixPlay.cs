using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixPlay
{
    class MatrixPlay
    {
        static void Main()
        {
            //const int HEIGHT = 12;
            //long[][] triangle = new long[HEIGHT + 1][];
            //for (int i = 0; i < HEIGHT; i++)
            //{
            //    triangle[i] = new long[i + 1];
            //}
            //...D...
            //..EFA..
            //.BCDEF.
            //ABCDEFA
            //.BCDEF.
            //..ABC..
            //...D...
            //...E...
            //..FAB..

           //int num = 7;
            char stringLetter = 'D';
            int dots = 3;
            string mumtiplyerDots = new string('.', dots);
            int mumtiplyer = 1;
           
            for (int i = 0; i < 14; i++)
            {

                mumtiplyerDots = new string('.', dots);
                Console.Write(mumtiplyerDots);

                for (int p = 0; p < 7 - 2 * dots; p++)
                {
                    Console.Write(stringLetter);
                    stringLetter++;
                    if (stringLetter=='G')
                    {
                        stringLetter ='A';
                    }
                }

                Console.WriteLine(mumtiplyerDots);
                dots -= mumtiplyer;
                
                if (dots == -1)
                {
                    dots = 1;
                    mumtiplyer = -1;
                }
                if (dots == 4)
                {
                    mumtiplyer = 1;
                    dots -= mumtiplyer;
                }
                Console.WriteLine();
            }
            
         }
    }
}


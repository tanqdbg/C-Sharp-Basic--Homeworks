using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixOfPalindromes
{
    static void Main()
    {
        int r = Int32.Parse(Console.ReadLine());
        int c = Int32.Parse(Console.ReadLine());
        char a = 'a';
        char aPlus = 'a';
        for (int row = 0; row < r; row++)
        {
            for (int coll = 0; coll < c; coll++)
            {
                Console.Write("{0}{1}{0} ", a, Convert.ToChar(aPlus));
                aPlus++;
            }
            Console.WriteLine();
            a++;
            aPlus = a;
        }

        // друго решение с матрица
        //Console.WriteLine("Enter matrix dimensions");
        //Console.Write("height: ");
        //int height;
        //bool heightParse = int.TryParse(Console.ReadLine(), out height);
        //Console.Write("width: ");
        //int width;
        //bool widthParse = int.TryParse(Console.ReadLine(), out width);
        //if (!heightParse || !widthParse || height < 1 || width < 1)
        //{
        //    Console.WriteLine("invalid input");
        //    return;
        //}
        //string[,] polindromes = new string[height, width];
        //for (int i = 0; i < height; i++)
        //{
        //    for (int j = 0; j < width; j++)
        //    {
        //        polindromes[i, j] = "" + (char)('a' + i) + (char)('a' + i + j) + (char)('a' + i);
        //        Console.Write(polindromes[i, j] + " ");
        //    }
        //    Console.WriteLine();
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NewHouse

{
    class NewHouse
    {
        static void Main(string[] args)
        {
            double n = Int32.Parse(Console.ReadLine());
            double middle = (((n-1)/2));
            //Console.WriteLine(middle);
            double countup = 0;
            double countdown = middle;
           // double allStars = 1;
            char s = '*';
            char t = '-';
            char l = '|';
            for (int row = 0; row <= middle; row++)
            {
                for (int col = 0; col < middle; col++)
                {
                    if (col >= (countdown))
                    {
                        Console.Write(s);
                    }
                    else
                    {
                        Console.Write(t);
                    }
                }

                countdown--;
                Console.Write(s);

                for (int col = 0; col < middle; col++)
                {
                    if (col >= (countdown))
                    {
                        Console.Write(t);
                    }
                    else
                    {
                        Console.Write(s);
                    }
                }
                countup++;
                Console.WriteLine();   

                    //for (int col = 0; col < middle; col++)
                    //{
                    //    if (col >= (countup))
                    //    {
                    //        Console.Write(t);
                    //    }
                    //    else
                    //    {
                    //        Console.Write(s);
                    //    }
                    //}
                    //countup++;
                    //Console.WriteLine();   
            }
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(l);
            //    for (int j = 0; j < n-2; j++)
            //    {
            //        Console.Write(s);
            //    }
            //    Console.Write(l);
            //    Console.WriteLine(); 
            //}

        }
    }
}

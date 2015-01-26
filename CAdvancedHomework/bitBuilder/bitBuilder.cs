using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitBuilder
{
    class bitBuilder
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            while (true)
            {
                string num = Console.ReadLine();
                if (num == "quit")
                {
                    break;
                }
                int a = int.Parse(num);
                string order = Console.ReadLine();

                switch (order)
                {
                    case"flip":
                        Flip( n, a);
                        break;
                    case "insert":
                        Insert(n, a);
                        break;
                    case "semove":
                        Remove(n, a);
                        break;
                    case "skip":
                        Skip(n, a);
                        break;
                    default:
                        break;
                }
                
            }
        }

        static int Skip(int n, int a)
        {
            throw new NotImplementedException();
        }

        static int Remove(int n, int a)
        {
            throw new NotImplementedException();
        }

        static int Insert(int n, int a)
        {
            throw new NotImplementedException();
        }

        static int Flip(int n, int a)
        {
            if (((n >> a) & 1) > 0)
            {
                int mask = ~(1 << a);
                n = (n & mask);
            }
            else
            {
                int mask = 1 << a;
                n = n | mask;
            }
            return n;
        }
       
    }
}

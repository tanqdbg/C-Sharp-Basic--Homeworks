//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _12.CountOfNames
//{
//    class CountOfNames
//    {
//        static void Main()
//        {
//            List<string> nameList = new List<string>() { "Peter", "Steve", "Nakov", "Steve", "Alex", "Nakov"};
//            nameList.Sort();
//            string lastchar = nameList.First();
//            int counter = 0;
//            foreach (var item in nameList)
//            {
//                Console.Write(item + " ");
//            }
//            Console.WriteLine();
//            foreach (var name in nameList)
//            {
//                if (name == lastchar)
//                {
//                    counter++;
//                }
//                else
//                {
//                    Console.Write(lastchar + " -> " + "{0}", counter);
//                    Console.WriteLine();
//                    lastchar = name;
//                    counter = 1;
//                }
//            }
//            Console.Write(lastchar + " -> " + "{0}", counter);
//            Console.WriteLine();
//        }
        using System;
using System.Collections.Generic;
using System.Linq;
class CountNames
{
    static void Main()
    {
        Console.WriteLine("Enter list of names on a line, separated by a space:");
        List<string> input = new List<string>{"Peter", "Steve", "Nakov", "Steve", "Alex", "Nakov"};//(Console.ReadLine().Split(new char[] { ' ' },
            //StringSplitOptions.RemoveEmptyEntries));
        List<string> names = input.Distinct().OrderBy(c => c).ToList();
        foreach (string name in names)
        {
            Console.WriteLine("{0} -> {1}", name, input.Count(x => x == name));
        }
    }
}

//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.JoinLists
{
    class JoinLists
    {
        static void Main()
        {
            List<int> firstList = new List<int>(){5, 4, 3, 2, 1};
            List<int> secondList = new List<int>(){ 6, 3, 2};
            foreach (var item in secondList)
            {
                if (firstList.Contains(item))
                {
                    continue;
                }
                else
                {
                    firstList.Add(item);
                }
            }
            firstList.Sort();
            foreach (var item in firstList)
            {
               Console.Write(item + " ");
            }
        }
        ////друго решение
        //static void Main()
        //{
        //    Console.WriteLine("Enter first list of integers on a line, separated by a space:");
        //    List<string> firstList = new List<string>(Console.ReadLine().Split(new char[] { ' ' },
        //        StringSplitOptions.RemoveEmptyEntries));
        //    Console.WriteLine("Enter second list of integers on a line, separated by a space:");
        //    List<string> secondList = new List<string>(Console.ReadLine().Split(new char[] { ' ' },
        //        StringSplitOptions.RemoveEmptyEntries));
        //    firstList.AddRange(secondList);
        //    List<int> numbersList = new List<int>();
        //    for (int i = 0; i < firstList.Count; i++)
        //    {
        //        int n;
        //        bool nParse = int.TryParse(firstList[i], out n);
        //        if (!nParse)
        //        {
        //            Console.WriteLine("invalid input");
        //            return;
        //        }
        //        numbersList.Add(n);
        //    }
        //    numbersList = numbersList.Distinct().ToList();
        //    numbersList.Sort();
        //    Console.WriteLine("Output:\n" + string.Join(" ", numbersList));
        //}
    }
}

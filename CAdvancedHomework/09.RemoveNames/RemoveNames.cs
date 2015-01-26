using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RemoveNames
{
    class RemoveNames
    {
        static void Main(string[] args)
        {
            List<string> firstList = new List<string>() { "Peter", "Alex", "Maria", "Todor", "Steve", "Diana", "Steve"};
            // List<string> firstList = new List<string>(Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries));
            
            List<string> secondList = new List<string>(){"Todor","Steve","Nakov"};
            //List<string> secondList = new List<string>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            
            List<string> firstRemovedNames = new List<string>();
            foreach (var item in firstList)
            {
                if (secondList.Contains(item))
                {
                    continue;
                }
                else
                {
                    Console.Write(item + " ");
                }

                // друг вариант :))
                //for (int i = 0; i < secondList.Count; i++)
                //{
                //    firstList.RemoveAll(item => item == secondList[i]);
                //}
                //Console.WriteLine("Output:\n" + string.Join(" ", firstList));
            }
        }
    }
}

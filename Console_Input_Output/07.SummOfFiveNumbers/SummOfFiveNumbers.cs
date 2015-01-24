using System;

class SummOfFiveNumbers
{
    static void Main(string[] args)
    {
        //Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. 

        string[] tokens = Console.ReadLine().Split();

        double a = double.Parse(tokens[0]);
        double b = double.Parse(tokens[1]);
        double c = double.Parse(tokens[2]);
        double d = double.Parse(tokens[3]);
        double e = double.Parse(tokens[4]);

        double summ = (a + b + c + d + e);
        Console.WriteLine("summ = {0}", summ);

        ////////////////////////////////////////////////
        ///variant 2 
        /// Console.WriteLine("Please enter a five numbers separated by a space:");
        /// 
        //string nums = Console.ReadLine();
        //string[] splitNums = nums.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //double sum = 0;
        //for (int i = 0; i < splitNums.Length; i++)
        //{
        //    sum = sum + double.Parse(splitNums[i]);
        //}
        //Console.WriteLine(sum);
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //string[] splitNums = nums.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        //- имаme въведен стринг nums, който четеm от конзолата - предполага се, че там въвеждаme числа и между тях специален символ "празно място" (space) ' '

        //- дефинираme масив от стрингове, който се казва splitNums (ето това string[] splitNums)

        //- nums.Split с параметър ' ' разделя nums на отделни стрингове (масив от стрингове), като разделителят е ' '

        //- nums.Split с параметър StringSplitOptions.RemoveEmptyEntries премахва, елементите на масива, които евентуално са празни

        //            (например, ако въведеm два последователни ' ')

        //Като резултат от тези операции, масивът splitNums се запълва с n броя стрингове, получени от разбиването на nums, като разделител е ' ' 

        //    (тоест, ' ' се среща в nums точно n-1 пъти).

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // и още едно
        //string input = Console.ReadLine();
        //int numbers = input.Split(' ').Sum(x => int.Parse(x));
        //Console.WriteLine(numbers);

        //using System;
        //using System.Collections.Generic;
        //using System.Linq;
        //using System.Text;
        //using System.Threading.Tasks;
    }
}


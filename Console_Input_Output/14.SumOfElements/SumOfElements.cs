using System;

class SumOfElements
{
    static void Main(string[] args)
    {
/////////You are given n numbers. Find an element that is equal to the sum of all of the other elements.
      
        string[] lineArr = Console.ReadLine().Split();
        int summ = 0;
        int diff = 0;
        int bigestElement = 0;                                                
        int element = 0;  
        for (int i = 0; i < lineArr.Length; i++)
        {
            element = Int32.Parse(lineArr[i]);

            if (element >= bigestElement)
            {
                bigestElement = element;
            }
            summ = summ + element;
        }
            
        if (bigestElement == summ - bigestElement)
        {
            Console.WriteLine("Yes, sum={0}", (bigestElement));
        }
        else 
        {
            diff = Math.Abs(bigestElement - (summ - bigestElement));
            Console.WriteLine("No, diff={0}", diff);
        }
    }
}
        ///////////////////////////////////////////////////////////////////////////////////
        //АВТОРСКО РЕШЕНИЕ


//       using System;

//class SumOfElements
//{
//    static void Main()
//    {
//        string inputLine = Console.ReadLine();
//        string[] numbers = inputLine.Split(' ');

//        int max = int.MinValue;
//        int sum = 0;
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            int element = int.Parse(numbers[i]);
//            sum = sum + element;
//            if (element > max)
//            {
//                max = element;
//            }
//        }

//        if (sum == 2 * max)
//        {
//            Console.WriteLine("Yes, sum=" + max);
//        }
//        else
//        {
//            int diff = Math.Abs(sum - 2 * max);
//            Console.WriteLine("No, diff=" + diff);
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BitsPaintBall
{
    static void Main()
    {
        string input = Console.ReadLine();
        int bestSumm = 0;
        int[] canvas = new int[10];
        for (int c = 0; c < canvas.Length; c++)
        {
            canvas[c] = 1023;
        }
        while (input != "End")
        {
            string[] parameters = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int rowInput = int.Parse(parameters[0]);
            int collInput = Convert.ToInt32(parameters[1]);
            int r = Convert.ToInt32(parameters[2]);
            int rowMin = Math.Max((rowInput - r), 0);
            int rowMax = Math.Min((rowInput + r), 9);
            int collMin = Math.Max((collInput - r), 0);
            int collMax = Math.Min((collInput + r), 9);
            string[] number = new string[10];
            for (int row = 0; row <= 9; row++)
                {
                    for (int coll = 9; coll >= 0; coll--)
                    {
                        char ch;
                        if ((row >= rowMin && row <= rowMax) && (coll >= collMin && coll <= collMax))
                        {
                            ch = '0';
                            number[row] += ch;
                        }
                        else
                        {
                            ch = '1';
                            number[row] += ch;
                        }
                    }
                }
                for (int g = 0; g < 10; g++)
                {
                    int someNum = Int32.Parse(Convert.ToString(number[g],2).PadLeft(10,'0'));
                    int somCanvals = canvas[g];
                    canvas[g] = (somCanvals & someNum);
                }
        input = Console.ReadLine();
        }
        int totalSumm = 0;
        for (int k = 0; k < canvas.Length; k++)
        {
            totalSumm += canvas[k];
        }
        Console.WriteLine(totalSumm);
    }
}


using System;

class WorkHours
{
    static void Main(string[] args)
    {
        int h = Int32.Parse(Console.ReadLine());
        int d = Int32.Parse(Console.ReadLine());
        int p = Int32.Parse(Console.ReadLine());
        double productivityTime = (((d*0.9)*12)*p/100);
        int productivityTimeHours = (int)productivityTime;
        
        if (productivityTimeHours-h>=0)
        {
            Console.WriteLine("Yes");
            Console.WriteLine(productivityTimeHours-h);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine(productivityTimeHours-h);
        }
    }
}


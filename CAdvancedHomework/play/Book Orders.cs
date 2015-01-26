using System;

class play
{
    static void Main(string[] args)
    {
        int broy = Int32.Parse(Console.ReadLine());
        decimal bookPrice;
        int numPackets;
        int allBooks = 0;
        int booksPerPaket;
        int totalbooks = 0;
        decimal prisePaket = 0;
        decimal totalPrice = 0;

        for (int i = 0; i < broy; i++)
        {
            numPackets = int.Parse(Console.ReadLine());
            booksPerPaket = int.Parse(Console.ReadLine());
            bookPrice = decimal.Parse(Console.ReadLine());
            totalbooks = (numPackets * booksPerPaket);
            prisePaket = (numPackets * booksPerPaket * bookPrice);

            if (numPackets >= 10 && numPackets < 20)
            {
                prisePaket *= 0.95m;
            }
            if (numPackets >= 20 && numPackets < 30)
            {
                prisePaket *= 0.94m;
            }
            if (numPackets >= 30 && numPackets < 40)
            {
                prisePaket *= 0.93m;
            }
            if (numPackets >= 40 && numPackets < 50)
            {
                prisePaket *= 0.92m;
            }
            if (numPackets >= 50 && numPackets < 60)
            {
                prisePaket *= 0.91m;
            }
            if (numPackets >= 60 && numPackets < 70)
            {
                prisePaket *= 0.90m;
            }
            if (numPackets >= 70 && numPackets < 80)
            {
                prisePaket *= 0.89m;
            }
            if (numPackets >= 80 && numPackets < 90)
            {
                prisePaket *= 0.88m;
            }
            if (numPackets >= 90 && numPackets < 100)
            {
                prisePaket *= 0.87m;
            }
            if (numPackets >= 100 && numPackets < 110)
            {
                prisePaket *= 0.86m;
            }
            if (numPackets >= 110)
            {
                prisePaket *= 0.85m;
            }
            allBooks += totalbooks;
            totalPrice += prisePaket;
        }

        Console.WriteLine(allBooks);
        Console.WriteLine("{0:0.00}", totalPrice);
    }
}


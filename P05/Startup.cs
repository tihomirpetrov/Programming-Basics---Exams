namespace P01
{
    using System;
    class Startup
    {
        public static void Main()
        {
            double printPagePrice = double.Parse(Console.ReadLine());
            double printCoverPrice = double.Parse(Console.ReadLine());
            double percentDiscount = double.Parse(Console.ReadLine());
            double designerPrice = double.Parse(Console.ReadLine());
            double percentPayed = double.Parse(Console.ReadLine());

            double bookPrice = (printPagePrice * 899) + (printCoverPrice * 2);
            double discount = bookPrice * (1 - (percentDiscount / 100));
            double designerPayment = discount + designerPrice;
            double teamMoney = designerPayment * (1 - (percentPayed / 100));
            Console.WriteLine($"Avtonom should pay {teamMoney:f2} BGN.");
        }
    }
}

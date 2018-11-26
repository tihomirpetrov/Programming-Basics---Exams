namespace P01
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int countSectors = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());

            double income = (capacity * ticketPrice) / countSectors;
            double totalIncome = income * countSectors;
            double moneyCharity = (totalIncome - (income * 0.75)) / 8;

            Console.WriteLine($"Total income - {totalIncome:f2} BGN");
            Console.WriteLine($"Money for charity - {moneyCharity:f2} BGN");
        }
    }
}
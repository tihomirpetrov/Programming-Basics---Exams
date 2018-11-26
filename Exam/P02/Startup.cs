namespace P02
{
    using System;
    class Startup
    {
        public static void Main()
        {
            string fansName = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beerBottles = int.Parse(Console.ReadLine());
            int chipsPackets = int.Parse(Console.ReadLine());

            double sumBeers = 1.20 * beerBottles;
            double chipsPrice = sumBeers * 0.45;
            double totalChipsPrice = Math.Ceiling(chipsPrice * chipsPackets);
            double totalSum = sumBeers + totalChipsPrice;

            if (budget >= totalSum)
            {
                Console.WriteLine($"{fansName} bought a snack and has {budget - totalSum:f2} money left.");
            }
            else if (budget < totalSum)
            {
                double neededMoney = Math.Abs(totalSum - budget);
                Console.WriteLine($"{fansName} needs {neededMoney:f2} more money!");
            }
        }
    }
}

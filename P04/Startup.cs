namespace P04
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int nCats = int.Parse(Console.ReadLine());
            int groupOne = 0;
            int groupTwo = 0;
            int groupThree = 0;
            double food = 0;
            double price = 0;

            for (int i = 1; i <= nCats; i++)
            {
                int nGrams = int.Parse(Console.ReadLine());
                if (nGrams >= 100 && nGrams < 200)
                {
                    groupOne++;
                    food +=  nGrams;
                }
                else if (nGrams >= 200 && nGrams < 300)
                {
                    groupTwo++;
                    food += nGrams;
                }
                else if (nGrams >= 300 && nGrams < 400)
                {
                    groupThree++;
                    food += nGrams;
                }
            }

            price = (food / 1000) * 12.45;
            Console.WriteLine($"Group 1: {groupOne} cats.");
            Console.WriteLine($"Group 2: {groupTwo} cats.");
            Console.WriteLine($"Group 3: {groupThree} cats.");
            Console.WriteLine($"Price for food per day: {Math.Round(price,2)} lv. ");

        }
    }
}

namespace P02_2
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int minutesWalk = int.Parse(Console.ReadLine());
            int walkDaily = int.Parse(Console.ReadLine());
            int caloriesDaily = int.Parse(Console.ReadLine());
            int sumWalk = minutesWalk * walkDaily;
            int totalCaloriesDaily = sumWalk * 5;
            int caloriesForDay = caloriesDaily / 2;

            if (totalCaloriesDaily >= caloriesForDay)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalCaloriesDaily}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalCaloriesDaily}.");
            }
        }
    }
}

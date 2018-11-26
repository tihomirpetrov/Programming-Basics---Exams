namespace P04.RunningInThePark
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int nDays = int.Parse(Console.ReadLine());
            double sumDistance = 0;
            int totalMinutes = 0;
            int totalCalories = 0;
            for (int i = 1; i <= nDays; i++)
            {
                int minutesRun = int.Parse(Console.ReadLine());
                double dayDistance = double.Parse(Console.ReadLine());
                string unit = Console.ReadLine();
                totalMinutes += minutesRun;

                if (unit == "m")
                {
                    sumDistance += dayDistance / 1000;
                }
                else
                {
                    sumDistance += dayDistance;
                }
            }
            totalCalories = totalMinutes * 20;
            Console.WriteLine($"He ran {sumDistance:f2}km for {totalMinutes} minutes and burned {totalCalories} calories.");
        }
    }
}

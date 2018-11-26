namespace P05
{
    using System;
    class Startup
    {
        public static void Main()
        {
            string teamName = Console.ReadLine();
            int matchedPlayed = int.Parse(Console.ReadLine());
            double sumMinutes = 0;
            int extraTime = 0;
            int penalty = 0;

            for (int i = 1; i <= matchedPlayed; i++)
            {
                double durationOfMatch = double.Parse(Console.ReadLine());
                sumMinutes += durationOfMatch;

                if (durationOfMatch > 90 && durationOfMatch <= 120)
                {
                    extraTime++;
                }
                else if (durationOfMatch > 120)
                {
                    penalty++;
                }
            }
            double average = (sumMinutes / matchedPlayed);

            Console.WriteLine($"{teamName} has played {sumMinutes} minutes. Average minutes per game: {average:f2}");
            Console.WriteLine($"Games with penalties: {penalty}");
            Console.WriteLine($"Games with additional time: {extraTime}");
        }
    }
}

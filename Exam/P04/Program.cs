namespace P04
{
    using System;
    class Program
    {
        public static void Main()
        {
            string teamName = Console.ReadLine();
            int matchesPlayed = int.Parse(Console.ReadLine());
            int sumGoals = 0;
            int sumGoalsReceived = 0;
            int gamePoints = 0;
            int goalsInMatches = 0;
            int goalsInMatchesReceived = 0;

            for (int i = 1; i <= matchesPlayed; i++)
            {
                int goals = int.Parse(Console.ReadLine());
                int goalsReceived = int.Parse(Console.ReadLine());

                sumGoals += goals;
                sumGoalsReceived += goalsReceived;

                if (sumGoals > sumGoalsReceived)
                {
                    gamePoints += 3;
                }
                else if (sumGoals == sumGoalsReceived)
                {
                    gamePoints += 1;
                }

                goalsInMatches += sumGoals;
                goalsInMatchesReceived += sumGoalsReceived;
                sumGoals = 0;
                sumGoalsReceived = 0;
            }

            if (goalsInMatches >= goalsInMatchesReceived)
            {
                Console.WriteLine($"{teamName} has finished the group phase with {gamePoints} points.");
                Console.WriteLine($"Goal difference: {goalsInMatches - goalsInMatchesReceived}.");
            }
            else
            {
                Console.WriteLine($"{teamName} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {goalsInMatches - goalsInMatchesReceived}.");
            }
        }
    }
}

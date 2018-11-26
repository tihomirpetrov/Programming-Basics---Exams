namespace P04.CreditSystem
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int countCourses = int.Parse(Console.ReadLine());
            double totalCredits = 0;
            double totalScore = 0;
            for (int i = 1; i <= countCourses; i++)
            {
                int creditAndScore = int.Parse(Console.ReadLine());
                double score = creditAndScore % 10;
                double credit = creditAndScore / 10; 
                totalScore += score;
                
                if (score == 2)
                {
                    totalCredits += credit * 0;
                }
                if (score == 3)
                {
                    totalCredits += credit * 0.5;
                }
                if (score == 4)
                {
                    totalCredits += credit * 0.7;
                }
                if (score == 5)
                {
                    totalCredits += credit * 0.85;
                }
                if (score == 6)
                {
                    totalCredits += credit * 1;
                }
            }
            
            totalScore = totalScore / countCourses;
            Console.WriteLine($"{totalCredits:f2}");
            Console.WriteLine($"{totalScore:f2}");
        }
    }
}
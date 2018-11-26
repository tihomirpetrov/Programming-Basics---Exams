namespace P03_2.CatTrainingAttendance
{
    using System;
    class Startup
    {
        static void Main()
        {
            int hourLectureStarts = int.Parse(Console.ReadLine());
            int hourRegistered = int.Parse(Console.ReadLine());
            int minRegistered = int.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();
            double bonusPoints = 0;

            if (hourLectureStarts - 1 >= hourRegistered)
            {
                bonusPoints = 1.5;
            }
            else
            {
                if (hourLectureStarts == hourRegistered && minRegistered <= 30)
                {
                    bonusPoints = 1;
                }
                else
                {
                    bonusPoints = 0.5;
                }
            }
            

            if (dayOfWeek == "Monday" || dayOfWeek == "Wednesday" || dayOfWeek == "Friday")
            {
                bonusPoints += 0.6;
            }
            else if (dayOfWeek == "Tuesday" || dayOfWeek == "Thursday" || dayOfWeek == "Saturday")
            {
                bonusPoints += 0.8;
            }
            else if (dayOfWeek == "Sunday")
            {
                bonusPoints += 2;
            }

            Console.WriteLine($"{bonusPoints:f2}");
        }
    }
}

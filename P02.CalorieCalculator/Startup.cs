namespace P02.CalorieCalculator
{
    using System;
    class Startup
    {
        public static void Main()
        {
            string sex = Console.ReadLine();
            double weightKg = double.Parse(Console.ReadLine());
            double heightInMeters = double.Parse(Console.ReadLine());
            double years = double.Parse(Console.ReadLine());
            string activity = Console.ReadLine();
            double heightInCm = heightInMeters * 100;
            double bhmMale = 66 + (13.7 * weightKg) + (5 * heightInCm) - (6.8 * years);
            double bhmFemale = 655 + (9.6 * weightKg) + (1.8 * heightInCm) - (4.7 * years);
            

            if (activity == "sedentary")
            {
                if (sex == "m")
                {
                    bhmMale = bhmMale * 1.2;
                }
                if (sex == "f")
                {
                    bhmFemale = bhmFemale * 1.2;
                }
            }

            if (activity == "lightly active")
            {
                if (sex == "m")
                {
                    bhmMale = bhmMale * 1.375;
                }
                if (sex == "f")
                {
                    bhmFemale = bhmFemale * 1.375;
                }
            }

            if (activity == "moderately active")
            {
                if (sex == "m")
                {
                    bhmMale = bhmMale * 1.55;
                }
                if (sex == "f")
                {
                    bhmFemale = bhmFemale * 1.55;
                }
            }

            if (activity == "very active")
            {
                if (sex == "m")
                {
                    bhmMale = bhmMale * 1.725;
                }
                if (sex == "f")
                {
                    bhmFemale = bhmFemale * 1.725;
                }
            }

            if (sex == "m")
            {
                Console.WriteLine($"To maintain your current weight you will need {Math.Ceiling(bhmMale)} calories per day.");
            }
            else
            {
                Console.WriteLine($"To maintain your current weight you will need {Math.Ceiling(bhmFemale)} calories per day.");
            }
        }
    }
}

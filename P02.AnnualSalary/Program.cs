namespace P02.AnnualSalary
{
    using System;
    class Program
    {
        public static void Main()
        {
            int yearsProfessional = int.Parse(Console.ReadLine());
            string speciality = Console.ReadLine();
            double totalMoney = 0;

            if (speciality == "C# Developer")
            {
                
                if (yearsProfessional <= 5)
                {
                    totalMoney = (5400 - (5400 * 0.658)) * 12;
                }
                else
                {
                    totalMoney = 5400 * 12;
                }
            }

            if (speciality == "Java Developer")
            {
                
                if (yearsProfessional <= 5)
                {
                    totalMoney = (5700 - (5700 * 0.658)) * 12;
                }
                else
                {
                    totalMoney = 5700 * 12;
                }
            }

            if (speciality == "Front-End Web Developer")
            {
                
                if (yearsProfessional <= 5)
                {
                    totalMoney = (4100 - (4100 * 0.658)) * 12;
                }
                else
                {
                    totalMoney = 4100 * 12;
                }
            }

            if (speciality == "UX / UI Designer")
            {
                
                if (yearsProfessional <= 5)
                {
                    totalMoney = (3100 - (3100 * 0.658)) * 12;
                }
                else
                {
                    totalMoney = 3100 * 12;
                }
            }

            if (speciality == "Game Designer")
            {
                
                if (yearsProfessional <= 5)
                {
                    totalMoney = (3600 - (3600 * 0.658)) * 12;
                }
                else
                {
                    totalMoney = 3600 * 12;
                }
            }

            Console.WriteLine($"Total earned money: {totalMoney:f2} BGN");
        }
    }
}

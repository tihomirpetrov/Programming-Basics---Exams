namespace P03.OnlineEducation
{
    using System;
    class Startup
    {
        public static void Main()
        {
            string eduFormAdvance = Console.ReadLine();
            int countFormAdvance = int.Parse(Console.ReadLine());
            string eduFormRegular = Console.ReadLine();
            int countFormRegular = int.Parse(Console.ReadLine());
            string eduFormLate = Console.ReadLine();
            int countFormLate = int.Parse(Console.ReadLine());
            int onlineStudents = 0;
            int onsiteStudents = 0;
            
            int sum = 0;

            if (eduFormAdvance == "online")
            {
                onlineStudents += countFormAdvance;
            }
            else if (eduFormAdvance == "onsite")
            {
                sum += countFormAdvance;
                if (sum <= 600)
                {
                    onsiteStudents += countFormAdvance;
                }
                else if (sum > 600)
                {
                    onsiteStudents += countFormAdvance - (countFormAdvance - 600);
                    onlineStudents += sum - onsiteStudents;
                }
                else
                {
                    onlineStudents += countFormAdvance;
                }                
            }

            if (eduFormRegular == "online")
            {
                onlineStudents += countFormRegular;
            }
            else if (eduFormRegular == "onsite")
            {
                sum += countFormRegular;
                if (sum <= 600)
                {
                    if (onsiteStudents + countFormRegular > 600)
                    {
                        onsiteStudents = countFormRegular - (countFormRegular - 600);
                    }
                    else
                    {
                        onsiteStudents += countFormRegular;
                    }                    
                }
                else
                {
                    onlineStudents += countFormRegular;
                }                
            }

            if (eduFormLate == "online")
            {
                onlineStudents += countFormLate;
            }
            else if (eduFormLate == "onsite")
            {
                sum += onsiteStudents;
                if (sum <= 600)
                {
                    onsiteStudents += countFormLate;
                }
                else
                {
                    onlineStudents += countFormLate;
                }                
            }            

            int totalStudents = onlineStudents + onsiteStudents;
            if (sum > 600)
            {
                onsiteStudents = sum - (sum - 600);
                onlineStudents = totalStudents - onsiteStudents;
            }
            Console.WriteLine($"Online students: {onlineStudents}");
            Console.WriteLine($"Onsite students: {onsiteStudents}");
            Console.WriteLine($"Total students: {totalStudents}");
        }
    }
}
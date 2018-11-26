namespace P03
{
    using System;
    class Startup
    {
        public static void Main()
        {
            string catRace = Console.ReadLine();
            string catGender = Console.ReadLine();
            double catMonths = 0;

            if (catRace == "British Shorthair")
            {
                if (catGender == "m")
                {
                    catMonths = (13 * 12) / 6;
                    Console.WriteLine($"{catMonths} cat months");
                }
                else if (catGender == "f")
                {
                    catMonths = (14 * 12) / 6;
                    Console.WriteLine($"{catMonths} cat months");
                }
            }

            else if (catRace == "Siamese")
            {
                if (catGender == "m")
                {
                    catMonths = (15 * 12) / 6;
                    Console.WriteLine($"{catMonths} cat months");
                }
                else if (catGender == "f")
                {
                    catMonths = (16 * 12) / 6;
                    Console.WriteLine($"{catMonths} cat months");
                }
            }

            else if (catRace == "Persian")
            {
                if (catGender == "m")
                {
                    catMonths = (14 * 12) / 6;
                    Console.WriteLine($"{catMonths} cat months");
                }
                else if (catGender == "f")
                {
                    catMonths = (15 * 12) / 6;
                    Console.WriteLine($"{catMonths} cat months");
                }
            }

            else if (catRace == "Ragdoll")
            {
                if (catGender == "m")
                {
                    catMonths = (16 * 12) / 6;
                    Console.WriteLine($"{catMonths} cat months");
                }
                else if (catGender == "f")
                {
                    catMonths = (17 * 12) / 6;
                    Console.WriteLine($"{catMonths} cat months");
                }
            }

            else if (catRace == "American Shorthair")
            {
                if (catGender == "m")
                {
                    catMonths = (12 * 12) / 6;
                    Console.WriteLine($"{catMonths} cat months");
                }
                else if (catGender == "f")
                {
                    catMonths = (13 * 12) / 6;
                    Console.WriteLine($"{catMonths} cat months");
                }
            }

            else if (catRace == "Siberian")
            {
                if (catGender == "m")
                {
                    catMonths = (11 * 12) / 6;
                    Console.WriteLine($"{catMonths} cat months");
                }
                else if (catGender == "f")
                {
                    catMonths = (12 * 12) / 6;
                    Console.WriteLine($"{catMonths} cat months");
                }
            }
            else //(catRace != "British Shorthair" || catRace != "Siamese" || catRace == "Persian" || catRace == "Radoll" || catRace == "American Shorthair" || catRace == "Siberian")
            {
                Console.WriteLine($"{catRace} is invalid cat!");
            }
        }
    }
}

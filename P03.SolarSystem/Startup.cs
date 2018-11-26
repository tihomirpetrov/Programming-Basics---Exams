namespace P03.SolarSystem
{
    using System;
    class Startup
    {
        public static void Main()
        {
            string planet = Console.ReadLine();
            int daysOnPlanet = int.Parse(Console.ReadLine());
            double distance = 0;
            double stayOnPlanet = 0;
            bool maxDays = true;

            if (planet == "Mercury")
            {
                distance = 2 * 0.61;
                stayOnPlanet = 2 * (226 * 0.61) + daysOnPlanet;
                if (daysOnPlanet > 7)
                {
                    maxDays = false;
                }
            }
            else if (planet == "Venus")
            {
                distance = 2 * 0.28;
                stayOnPlanet = 2 * (226 * 0.28) + daysOnPlanet;
                if (daysOnPlanet > 14)
                {
                    maxDays = false;
                }
            }
            else if (planet == "Mars")
            {
                distance = 2 * 0.52;
                stayOnPlanet = 2 * (226 * 0.52) + daysOnPlanet;
                if (daysOnPlanet > 20)
                {
                    maxDays = false;
                }
            }
            else if (planet == "Jupiter")
            {
                distance = 2 * 4.2;
                stayOnPlanet = 2 * (226 * 4.2) + daysOnPlanet;
                if (daysOnPlanet > 5)
                {
                    maxDays = false;
                }
            }
            else if (planet == "Saturn")
            {
                distance = 2 * 8.52;
                stayOnPlanet = 2 * (226 * 8.52) + daysOnPlanet;
                if (daysOnPlanet > 3)
                {
                    maxDays = false;
                }
            }
            else if (planet == "Uranus")
            {
                distance = 2 * 18.21;
                stayOnPlanet = 2 * (226 * 18.21) + daysOnPlanet;
                if (daysOnPlanet > 3)
                {
                    maxDays = false;
                }
            }
            else if (planet == "Neptune")
            {
                distance = 2 * 29.09;
                stayOnPlanet = 2 * (226 * 29.09) + daysOnPlanet;
                if (daysOnPlanet > 2)
                {
                    maxDays = false;
                }
            }
            else
            {
                Console.WriteLine("Invalid planet name!");
                return;
            }
            if (!maxDays)
            {
                Console.WriteLine("Invalid number of days!");
                return;
            }

            Console.WriteLine($"Distance: {distance:f2}");
            Console.WriteLine($"Total number of days: {stayOnPlanet:f2}");
        }
    }
}

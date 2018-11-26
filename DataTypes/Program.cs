namespace P01.PracticeIntegers
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            double metersPerSec = 273.2241 / distanceInMeters;
            double kmPerHour = 0.9836066;
            double milesPerHour = 0.6113155;

            Console.WriteLine(metersPerSec);
            Console.WriteLine(kmPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
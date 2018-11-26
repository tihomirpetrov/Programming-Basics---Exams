namespace P01.Moon
{
    using System;
    class Startup
    {
        public static void Main()
        {
            double averageSpeed = double.Parse(Console.ReadLine());
            double leters = double.Parse(Console.ReadLine());

            double hoursNeeded = Math.Ceiling((384400 * 2) / averageSpeed);
            double fuelNeeded = (leters * (384400 * 2)) / 100;
            Console.WriteLine(hoursNeeded + 3);
            Console.WriteLine(fuelNeeded);
        }
    }
}

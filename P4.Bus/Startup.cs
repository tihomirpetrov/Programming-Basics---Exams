namespace P04.Bus
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int passengersFromStart = int.Parse(Console.ReadLine());
            int busStop = int.Parse(Console.ReadLine());
            int passengersOut = 0;
            int passengersIn = 0;
            int sumPassengersIn = 0;
            int sumPassengersOut = 0;
            for (int i = 1; i <= busStop; i++)
            {
                passengersOut = int.Parse(Console.ReadLine());
                passengersIn = int.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    sumPassengersOut += passengersOut;
                    sumPassengersIn += passengersIn + 2;
                }
                if (i % 2 == 0)
                {
                    sumPassengersOut += passengersOut + 2;
                    sumPassengersIn += passengersIn;
                }                
            }
            int totalPassengers = (passengersFromStart + sumPassengersIn) - sumPassengersOut;
            Console.WriteLine($"The final number of passengers is : {totalPassengers}");
        }
    }
}
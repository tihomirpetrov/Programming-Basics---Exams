namespace P01
{
    using System;
    class Startup
    {
        public static void Main()
        {
            double bedPrice = double.Parse(Console.ReadLine());
            double toiletPrice = double.Parse(Console.ReadLine());
            double foodPrice = toiletPrice + (toiletPrice * 0.25);
            double toysPrice = foodPrice - (foodPrice * 0.5);
            double doctorPrice = toysPrice + (toysPrice * 0.1);
            double totalMonth = (toiletPrice + foodPrice + toysPrice + doctorPrice);
            double unexpected = ((toiletPrice + foodPrice + toysPrice + doctorPrice) * 0.05);
            double oneYearcost = bedPrice + (12 * totalMonth) + (12 * unexpected);

            Console.WriteLine($"{oneYearcost:f2} lv.");
        }
    }
}

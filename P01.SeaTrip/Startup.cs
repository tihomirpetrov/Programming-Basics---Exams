namespace P01.SeaTrip
{
    using System;
    class Startup
    {
        public static void Main()
        {
            double foodMoney = double.Parse(Console.ReadLine());
            double souvenirsMoney = double.Parse(Console.ReadLine());
            double hotelMoney = double.Parse(Console.ReadLine());
            double liters = (420 * 0.07);
            double fuel = liters * 1.85;
            double foodAndSouvenirs3days = 3 * foodMoney + 3 * souvenirsMoney;
            double hotelStay1 = hotelMoney * 0.9;
            double hotelStay2 = hotelMoney * 0.85;
            double hotelStay3 = hotelMoney * 0.8;
            double totalSum = fuel + foodAndSouvenirs3days + hotelStay1 + hotelStay2 + hotelStay3;

            Console.WriteLine($"Money needed: {totalSum:f2}");
        }
    }
}

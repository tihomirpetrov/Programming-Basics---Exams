namespace P06.HappyCatParking
{
    using System;
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double parking = 0;
            double sum = 0;
            double total = 0;
            for (int i = 1; i <= days; i++)
            {
                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 != 0)
                        {
                            parking += 2.50;
                        }
                        else
                        {
                            parking += 1;
                        }
                    }
                    if (i % 2 != 0)
                    {
                        if (j % 2 == 0)
                        {
                            parking += 1.25;
                        }
                        else
                        {
                            parking += 1;
                        }
                    }
                }
                sum = parking;
                Console.WriteLine($"Day: {i} - {sum:f2} leva");
                total += sum;
                parking = 0;
            }
            
            Console.WriteLine($"Total: {total:f2} leva");
        }
    }
}

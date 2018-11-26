namespace P06.SumAndProduct
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int a = 1; a <= 9; a++)
                {
                    for (int b = 9; b >= a; b--)
                    {
                        for (int c = 0; c <= 9; c++)
                        {
                            for (int d = 9; d >= c; d--)
                            {
                                int sum = a + b + c + d;
                                int multiplied = a * b * c * d;
                                if (sum == multiplied && n % 10 == 5)
                                {
                                    Console.WriteLine($"{a}{b}{c}{d}");
                                    return;
                                }
                                else if (multiplied / sum == 3 && n % 3 == 0)
                                {
                                    Console.WriteLine($"{d}{c}{b}{a}");
                                    return;
                                }                               
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Nothing found");
        }
    }
}
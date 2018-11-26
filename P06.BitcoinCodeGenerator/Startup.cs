namespace P06.BitcoinCodeGenerator
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int counter = 0;
            int m = 33;
            int n = 58;

            for (int a3 = 1; a3 <= a; a3++)
            {
                for (int a4 = 1; a4 <= b; a4++)
                {

                    if (counter >= c)
                    {
                        break;
                    }
                    if (m > 47)
                    {
                        m = 33;
                    }
                    if (n > 64)
                    {
                        n = 58;
                    }
                   
                    Console.Write($"{(char)m}{(char)n}{a3}{a4}{(char)n}{(char)m}|");
                   
                    counter++;
                    m++;
                    n++;
                }
            }
            Console.WriteLine();
        }
    }
}
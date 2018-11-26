namespace P06.BankNumberGenerator
{
    using System;

    class Startup
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            char d = char.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int fN = int.Parse(Console.ReadLine());
            int counter = 0;
            string combination = string.Empty;

            for (int i = a; i <= 99; i++)
            {
                for (char j = b; j <= 'Z'; j++)
                {
                    for (char k = c; k <= 'z'; k++)
                    {
                        for (char l = d; l <= 'Z'; l++)
                        {
                            for (int m = e; m >= 10; m--)
                            {
                                if (i % 10 == 2 && m % 10 == 5)
                                {
                                    counter++;
                                    if (counter == fN)
                                    {
                                        combination = $"{i}{j}{k}{l}{m}";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(combination);
        }
    }
}

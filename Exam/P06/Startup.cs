namespace P06
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int numberOfCombination = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int a1 = 66; a1 <= 76; a1 += 2)
            {
                for (char a2 = 'f'; a2 >= 'a'; a2--)
                {
                    for (char a3 = 'A'; a3 <= 'C'; a3++)
                    {
                        for (int a4 = 1; a4 <= 10; a4++)
                        {
                            for (int a5 = 10; a5 >= 1; a5--)
                            {
                                counter++;
                                if (counter == numberOfCombination)
                                {
                                    int sum = a1 + a2 + a3 + a4 + a5;
                                    Console.WriteLine($"Ticket combination: {(char)a1}{a2}{a3}{a4}{a5}");
                                    Console.WriteLine($"Prize: {sum} lv.");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

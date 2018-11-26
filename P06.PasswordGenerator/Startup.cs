namespace P06.PasswordGenerator
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine().ToUpper());
            char c = char.Parse(Console.ReadLine().ToLower());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int counter = 0;
            string combination = string.Empty;
            for (int a1 = 1; a1 <= a; a1++)
            {
                for (char a2 = 'A'; a2 <= b; a2++)
                {
                    for (char a3 = 'a'; a3 <= c; a3++)
                    {
                        for (int a4 = 1; a4 <= d; a4++)
                        {
                            for (int a5 = 1; a5 <= e; a5++)
                            {
                                for (int a6 = 1; a6 <= f; a6++)
                                {
                                    counter++;
                                    if (counter == N)
                                    {
                                        Console.WriteLine($"{a1}{a2}{a3}{a4}{a5}{a6}");
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (counter == N)
            {
                Console.WriteLine(combination);
            }
            else
            {
                Console.WriteLine("No password on this position");
            }
        }
    }

}

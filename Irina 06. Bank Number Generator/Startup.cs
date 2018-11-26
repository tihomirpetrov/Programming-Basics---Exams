using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write($"{j} ");
                }
                for (int k = n - 1; k >= n -i + 1; k--)
                {
                    Console.Write($"{k} ");
                }
                Console.WriteLine();
            }
        }
    }
}

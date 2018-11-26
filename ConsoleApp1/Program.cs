using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityCat = int.Parse(Console.ReadLine());
            for (int i = 1; i <= quantityCat ; i++)
            {
                string firstName = Console.ReadLine();
                string lastName = Console.ReadLine();
                int year = int.Parse(Console.ReadLine());

                int first = firstName[0];
                int last = lastName[0];
                Console.WriteLine($"{year}{first}{last}{i}");
            }
        }
    }
}

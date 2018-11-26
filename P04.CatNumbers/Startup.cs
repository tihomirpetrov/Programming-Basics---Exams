namespace P04.CatNumbers
{
    using System;
    class Startup
    {
        static void Main()
        {
            int catsCount = int.Parse(Console.ReadLine());
            string firstName = string.Empty;
            string lastName = string.Empty;
            int yearOfBirth = 0;
            int fromFirstName = ' ';
            int fromLastName = ' ';
            string generatedNumber = string.Empty;
            int counter = 0;
            string catsGenNum = string.Empty;
            for (int i = 0; i < catsCount; i++)
            {
                firstName = Console.ReadLine();
                lastName = Console.ReadLine();
                yearOfBirth = int.Parse(Console.ReadLine());
                counter++;
                fromFirstName = firstName[0];
                fromLastName = lastName[0];
                              
                generatedNumber = $"{yearOfBirth}{fromFirstName}{fromLastName}{counter}";
                Console.WriteLine(generatedNumber);                
            }              
        }
    }
}
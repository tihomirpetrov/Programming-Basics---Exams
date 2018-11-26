namespace P01_1
{
    using System;
    class Startup
    {
        public static void Main()
        {
            double fatPercent = double.Parse(Console.ReadLine());
            double proteinPercent = double.Parse(Console.ReadLine());
            double carbohydratePercent = double.Parse(Console.ReadLine());
            double totalCalories = double.Parse(Console.ReadLine());
            double waterPercent = double.Parse(Console.ReadLine());
            double gramsFat = ((fatPercent / 100) * totalCalories) / 9;
            double gramsProtein = ((proteinPercent / 100) * totalCalories) / 4;
            double gramsCarbohydrate = ((carbohydratePercent / 100) * totalCalories) / 4;
            double foodWeight = gramsFat + gramsProtein + gramsCarbohydrate;
            double caloriesPergram = totalCalories / foodWeight;
            double waterPergram = caloriesPergram * (1 - (waterPercent / 100));
            Console.WriteLine($"{waterPergram:f4}");
        }
    }
}

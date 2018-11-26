namespace P06
{
    using System;
    class Startup
    {
        public static void Main()
        {
            double foodForOneCat = double.Parse(Console.ReadLine());
            foodForOneCat = foodForOneCat * 1000;
            string gramsEaten = string.Empty;
            double quantity = 0;
            while ((gramsEaten = Console.ReadLine()) !="Adopted")
            {
                quantity += double.Parse(gramsEaten);
            }
            if (foodForOneCat >= quantity)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodForOneCat - quantity} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {quantity - foodForOneCat} grams more.");
            }
        }
    }
}

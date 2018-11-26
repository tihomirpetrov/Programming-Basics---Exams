namespace P03.FitnessCard
{
    using System;
    class Startup
    {
        public static void Main()
        {
            int amount = int.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double cardPrice = 0;
            if (sex == 'm')
            {
                if (sport == "Gym")
                {
                    if (age <= 19)
                    {
                        cardPrice = 42 - (42 * 0.2);
                    }
                    else
                    {
                        cardPrice = 42;
                    }
                }
                else if (sport == "Boxing")
                {
                    if (age <= 19)
                    {
                        cardPrice = 41 - (41 * 0.2);
                    }
                    else
                    {
                        cardPrice = 41;
                    }

                }
                else if (sport == "Yoga")
                {
                    if (age <= 19)
                    {
                        cardPrice = 45 - (45 * 0.2);
                    }
                    else
                    {
                        cardPrice = 45;
                    }
                }
                else if (sport == "Zumba")
                {
                    if (age <= 19)
                    {
                        cardPrice = 34 - (34 * 0.2);
                    }
                    else
                    {
                        cardPrice = 34;
                    }
                }
                else if (sport == "Dances")
                {
                    if (age <= 19)
                    {
                        cardPrice = 51 - (51 * 0.2);
                    }
                    else
                    {
                        cardPrice = 51;
                    }
                }
                else if (sport == "Pilates")
                {
                    if (age <= 19)
                    {
                        cardPrice = 39 - (39 * 0.2);
                    }
                    else
                    {
                        cardPrice = 39;
                    }
                }

            }
            if (sex == 'f')
            {
                if (sport == "Gym")
                {
                    if (age <= 19)
                    {
                        cardPrice = 35 - (35 * 0.2);
                    }
                    else
                    {
                        cardPrice = 35;
                    }
                }
                else if (sport == "Boxing")
                {
                    if (age <= 19)
                    {
                        cardPrice = 37 - (37 * 0.2);
                    }
                    else
                    {
                        cardPrice = 37;
                    }

                }
                else if (sport == "Yoga")
                {
                    if (age <= 19)
                    {
                        cardPrice = 42 - (42 * 0.2);
                    }
                    else
                    {
                        cardPrice = 42;
                    }
                }
                else if (sport == "Zumba")
                {
                    if (age <= 19)
                    {
                        cardPrice = 31 - (31 * 0.2);
                    }
                    else
                    {
                        cardPrice = 31;
                    }
                }
                else if (sport == "Dances")
                {
                    if (age <= 19)
                    {
                        cardPrice = 53 - (53 * 0.2);
                    }
                    else
                    {
                        cardPrice = 53;
                    }
                }
                else if (sport == "Pilates")
                {
                    if (age <= 19)
                    {
                        cardPrice = 37 - (37 * 0.2);
                    }
                    else
                    {
                        cardPrice = 37;
                    }
                }
            }
            if (cardPrice <= amount)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                double neededAmount = Math.Abs(cardPrice - amount);
                Console.WriteLine($"You don't have enough money! You need ${neededAmount:f2} more.");
            }
        }
    }
}

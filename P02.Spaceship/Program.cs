namespace P02.Spaceship
{
    using System;
    class Program
    {
        public static void Main()
        {
            double shipWidth = double.Parse(Console.ReadLine());
            double shipLength = double.Parse(Console.ReadLine());
            double shipHeight = double.Parse(Console.ReadLine());
            double heighAstro = double.Parse(Console.ReadLine());

            double shipVolume = shipWidth * shipLength * shipHeight;
            double shipRoom = (heighAstro + 0.40) * 2 * 2;
            double placesInShip = Math.Floor(shipVolume / shipRoom);

            if (placesInShip >= 3 && placesInShip <= 10)
            {
                Console.WriteLine($"The spacecraft holds {placesInShip} astronauts.");
            }
            else if (placesInShip < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (placesInShip > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }

        }
    }
}

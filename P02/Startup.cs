namespace P02
{
    using System;

    class Startup
    {
        public static void Main()
        {
            double sleeve = double.Parse(Console.ReadLine());
            double frontSide = double.Parse(Console.ReadLine());
            string material = Console.ReadLine();
            string necktie = Console.ReadLine();
            double shirt = ((sleeve * 2) + (frontSide * 2)) + (((sleeve * 2) + (frontSide * 2)) * 0.1);
            double shirtInMeters = shirt/ 100;
            double price = 0;

            if (material == "Linen")
            {
                if (necktie == "Yes")
                {
                    price = ((shirtInMeters * 15) + 10) + (((shirtInMeters * 15) + 10) * 0.2);
                }
                else
                {
                    price = (shirtInMeters * 15) + 10;
                }
            }
            else if (material == "Cotton")
            {
                if (necktie == "Yes")
                {
                    price = ((shirtInMeters * 12) + 10) + (((shirtInMeters * 12) + 10) * 0.2);
                }
                else
                {
                    price = (shirtInMeters * 12) + 10;
                }
            }
            else if (material == "Denim")
                if (necktie == "Yes")
                {
                    price = ((shirtInMeters * 20) + 10) + (((shirtInMeters * 20) + 10) * 0.2);
                }
                else
                {
                    price = (shirtInMeters * 20) + 10;
                }
            else if (material == "Twill")
                if (necktie == "Yes")
                {
                    price = ((shirtInMeters * 16) + 10) + (((shirtInMeters * 16) + 10) * 0.2);
                }
                else
                {
                    price = (shirtInMeters * 16) + 10;
                }
            else if (material == "Flannel")
                if (necktie == "Yes")
                {
                    price = ((shirtInMeters * 11) + 10) + (((shirtInMeters * 11) + 10) * 0.2);
                }
                else
                {
                    price = (shirtInMeters * 11) + 10;
                }
            Console.WriteLine($"The price of the shirt is: {price:f2}lv.");
        }
    }
}
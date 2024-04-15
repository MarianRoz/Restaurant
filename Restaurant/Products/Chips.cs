using System;

namespace Restaurant.Products
{
    class Chips : Food
    {
        public Chips() { Console.WriteLine("Created chips"); }
        public override double CalculateHappiness(double happiness)
        {
            return happiness += (happiness / 100) * 5;
        }
    }
}

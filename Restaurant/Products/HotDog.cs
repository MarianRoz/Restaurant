using System;

namespace Restaurant.Products
{
    class HotDog : Food
    {
        public HotDog() { Console.WriteLine("Created hotdog"); }
        public override double CalculateHappiness(double happiness)
        {
            return happiness + 2;
        }
    }
}

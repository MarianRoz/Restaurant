using System;

namespace Restaurant.ExtrasProducts
{
    public class Mustard : Extra
    {
        public Mustard(IFood food) : base(food) { Console.WriteLine("Added mustard"); }
        public override double CalculateHappiness(double happiness)
        {
            return happiness + 1;
        }
    }
}

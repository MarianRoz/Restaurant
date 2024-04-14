namespace Restaurant.Products
{
    class Chips : Food
    {
        public override double CalculateHappiness(double happiness)
        {
            return happiness += (happiness / 100) * 5;
        }
    }
}

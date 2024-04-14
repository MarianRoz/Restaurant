namespace Restaurant.Products
{
    class HotDog : Food
    {
        public override double CalculateHappiness(double happiness)
        {
            return happiness + 2;
        }
    }
}

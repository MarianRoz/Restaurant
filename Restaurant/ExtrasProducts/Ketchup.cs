namespace Restaurant.ExtrasProducts
{
    public class Ketchup : Extra
    {
        public Ketchup(IFood food) : base(food) { }

        public override double CalculateHappiness(double happiness)
        {

            return (Food.CalculateHappiness(happiness) - happiness) * 2 + happiness;
        }
    }
}

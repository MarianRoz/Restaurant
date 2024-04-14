using Restaurant.Products;
using System.Collections.Generic;

namespace Restaurant
{
    public class Kitchen
    {
        private IFood AddExtras(IFood mainFood, IEnumerable<string> extras)
        { return mainFood; }
        internal IFood Cook(Order order)
        {
            IFood res = CreateMainFood(order.Food);
            return null;
        }
        public IFood CreateMainFood(string food)
        {
            HotDog hotDog = new HotDog();
            hotDog.CalculateHappiness(10);
            return null;
        }
    }
}

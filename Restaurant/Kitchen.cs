using Restaurant.ExtrasProducts;
using Restaurant.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant
{
    public class Kitchen
    {
        private IFood AddExtras(IFood mainFood, IEnumerable<string> extras)
        {
            if (extras.FirstOrDefault() == "Ketchup")
            {
                return new Ketchup(mainFood);
            }
            if (extras.FirstOrDefault() == "Mustard")
            {
                return new Mustard(mainFood);
            }
            return mainFood;
        }
        internal IFood Cook(Order order)
        {
            IFood mainFood = CreateMainFood(order.Food);
            IFood mainFoodWithExtras = AddExtras(mainFood, order.Extras);
            return mainFoodWithExtras;
        }
        public IFood CreateMainFood(string food)
        {
            if (food == "HotDog")
            {
                return new HotDog();
            }
            if (food == "Chips")
            {
                return new Chips();
            }
            else
            {
                Console.WriteLine($"{food} is not on menu");
            }
            return null;
        }
    }
}

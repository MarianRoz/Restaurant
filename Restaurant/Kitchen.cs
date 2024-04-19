using Restaurant.ExtrasProducts;
using Restaurant.Products;
using System;
using System.Collections.Generic;

namespace Restaurant
{
    public class Kitchen
    {
        private IFood AddExtras(IFood mainFood, IEnumerable<string> extras)
        {
            foreach (string item in extras)
            {
                if (item == "Ketchup")
                {
                    new Ketchup(mainFood);
                }
                if (item == "Mustard")
                {
                    new Mustard(mainFood);
                }
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

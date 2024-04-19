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
                try
                {
                    if (item != "Ketchup" && item != "Mustard")
                    {
                        throw new Exception($"{item} is not on the menu");
                    }
                    if (item == "Ketchup")
                    {
                        new Ketchup(mainFood);
                    }
                    if (item == "Mustard")
                    {
                        new Mustard(mainFood);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
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
            try
            {
                if (food != "HotDog" && food != "Chips")
                {
                    throw new Exception($"{food} is not on the menu");
                }
                if (food == "HotDog")
                {
                    return new HotDog();
                }
                if (food == "Chips")
                {
                    return new Chips();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            return null;
        }
    }
}

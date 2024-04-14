using System;
using System.Collections.Generic;

namespace Restaurant
{
    public class Order
    {
        public IEnumerable<string> Extras { get; }
        public string Food { get; }
        public void NotifyReady(IFood food)
        {
            FoodReadyEventArgs foodReadyEventArgs = new FoodReadyEventArgs();
            FoodReady.Invoke(Food, (FoodReadyEventArgs)foodReadyEventArgs.Food);
            Console.WriteLine("Food ready");
        }
        public Order(string food, IEnumerable<string> extras)
        {
            Food = food;
            Extras = extras;
        }


        public event EventHandler<FoodReadyEventArgs> FoodReady;
    }
}

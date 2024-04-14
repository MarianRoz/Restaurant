using Restaurant.ExtrasProducts;
using Restaurant.Products;
using System;
using System.Collections.Generic;

namespace Restaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Marian", 10);

            Kitchen kitchen = new Kitchen();
            Waitress waitress = new Waitress(kitchen);

            IEnumerable<string> extras = new List<string>() { "Ketchup" };
            Order order = new Order("HotDog", extras);

            waitress.TakeOrder(client, order);
            waitress.ServeOrders();





            order.FoodReady += (sender, foodName) =>
            {
                Console.WriteLine($"Food {foodName} is ready.");
            };

            Extra hotDogWithKetchup = new Ketchup(new HotDog());
            waitress.TakeOrder(client, order);

            kitchen.CreateMainFood(order.Food);
        }
    }
}

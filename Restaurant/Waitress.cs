using System;
using System.Collections.Generic;

namespace Restaurant
{
    public class Waitress
    {
        private Queue<Order> Orders = new Queue<Order>();

        private Kitchen Kitchen { get; set; }

        public void ServeOrders()
        {
            Order food = Orders.Dequeue();
            Kitchen.Cook(food);

            while (Orders.Count > 0)
            {
                Console.WriteLine($"Serving {food.Food} to client.");
            }
        }
        public void TakeOrder(Client client, Order order)
        {
            Orders.Enqueue(order);
            Console.WriteLine($"Order received: {order.Food}");
        }
        public Waitress(Kitchen kitchen)
        {
            Kitchen = kitchen;
        }
    }
}

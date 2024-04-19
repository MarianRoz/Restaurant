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

            IEnumerable<string> extras = new List<string>() { "Ketchup", "Mustard" };
            Order order = new Order("HotDog", extras);

            waitress.TakeOrder(client, order);
            waitress.ServeOrders();
        }
    }
}

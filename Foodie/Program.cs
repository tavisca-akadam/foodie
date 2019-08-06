using System;

namespace Foodie
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Food pizza = new Pizza();
            MyCart cart = new MyCart();

            cart.Add(pizza, 2);
            Order order = new Order(cart, "cash");
            Console.WriteLine(order.PlaceOrder());
            Console.ReadKey();
        }
    }
}

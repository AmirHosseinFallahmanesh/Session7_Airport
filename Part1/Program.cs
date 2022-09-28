using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = Cart.Create();
            cart.AddToCart(new CartLine() { Count = 2, ProductName = "s20", Price = 1000 });
            cart.AddToCart(new CartLine() { Count = 4, ProductName = "Iphone 13", Price = 1400 });
            cart.Clear();
            Console.WriteLine(cart.GetTotal());
        }
    }
}

using System.Collections.Generic;

namespace Part1
{
    class Cart
    {
        private static Cart cart = new Cart();
        public static Cart Create()
        {
            return cart;
        }
        private List<CartLine> cartLines;
        private Cart()
        {
            cartLines = new List<CartLine>();
        }

        public void AddToCart(CartLine cartLine)
        {
            cartLines.Add(cartLine);
        }

        public void Clear()
        {
            cartLines.Clear();
        }
        
        public double GetTotal()
        {
            double total = 0;

            foreach (var cartLine in cartLines)
            {
                total += cartLine.Price * cartLine.Count;
            }
            return total;
        }
    }
}

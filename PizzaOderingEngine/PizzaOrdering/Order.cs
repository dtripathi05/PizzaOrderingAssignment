using System.Collections.Generic;

namespace PizzaOrdering
{
    public class Order
    {
        double total;
        public double TotalBillAmount
        {
            get
            {
                total = 0;
                foreach (var pizza in CompleteOrder())
                {
                    total += pizza.Price;
                }
                return total;
            }
        }

        List<Pizza> OrderList;
        Cart cart = new Cart();
        public Cart GetCart()
        {
            return cart;
        }
        public void AddInCart(Pizza pizza)
        {
            GetCart().Add(pizza);

        }
        public List<Pizza> CompleteOrder()
        {
            OrderList = new List<Pizza>(GetCart().GetCartItem());
            return OrderList;
        }

        public void RemoveFromCart(Pizza pizza)
        {
            GetCart().Remove(pizza);
        }

    }
}

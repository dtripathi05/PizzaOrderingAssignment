using System.Collections.Generic;

namespace PizzaOrdering
{
    public class Order
    {
        List<Pizza> OrderList;
        Cart cart = new Cart();
        public Cart GetCart()
        {
            return cart;
        }
        public void AddInCart(Pizza pizza)
        {
            GetCart().AddToCart(pizza);

        }
        public List<Pizza> CompleteOrder()
        {
          OrderList= new List<Pizza>(GetCart().GetCartItem());
            return OrderList;
        }
       
      

    }
}

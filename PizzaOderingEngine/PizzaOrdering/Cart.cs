using System.Collections.Generic;

namespace PizzaOrdering
{
    public class Cart
    {
        List<Pizza> CartContains = new List<Pizza>();
        public void Add(Pizza pizza)
        {
            CartContains.Add(pizza);
        }
        public List<Pizza> GetCartItem()
        {
            return CartContains;
        }
        public void Remove(Pizza pizza)
        {
            CartContains.Remove(pizza);
        }
    }
}

using System.Collections.Generic;

namespace PizzaOrdering
{
    public class Menu
    {
        List<Pizza> MenuList = new List<Pizza>();
        public void AddToMenu(Pizza pizza)
        {
            MenuList.Add(pizza);
        }
        public List<Pizza> GetMenu()
        {
            return MenuList;
        }
    }
}

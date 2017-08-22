using System;
using System.Collections.Generic;

namespace PizzaOdering
{
    public class Pizza
    {
        public string  Name { get; set; }
        public int Price { get; set; }
        public string Toppings { get; set; }
       
    }

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
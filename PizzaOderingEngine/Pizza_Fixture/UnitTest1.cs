﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaOrdering;
namespace Pizza_Fixture
{
    [TestClass]
    public class Pizza_Fixture
    {
        [TestMethod]
        public void To_Get_The_Menu_Count()
        {
            Pizza pizza1 = new Pizza() { Name = "CountrySpecial", Price = 150, Toppings = "Mushroom" };
            Pizza pizza2 = new Pizza() { Name = "farmHouse", Price = 150, Toppings = "Extra cheese" };
            Pizza pizza3 = new Pizza() { Name = "Chicken", Price = 250, Toppings = "Chicken" };
            Pizza pizza4 = new Pizza() { Name = "Regular", Price = 100, Toppings = "Mixture" };
            Menu menu = new Menu();
            menu.AddToMenu(pizza1);
            menu.AddToMenu(pizza2);
            menu.AddToMenu(pizza3);
            menu.AddToMenu(pizza4);
            Assert.AreEqual(4, menu.GetMenu().Count);
        }
        [TestMethod]
        public void TO_Get_The_Ordered_Items()
        {
            Pizza pizza1 = new Pizza() { Name = "CountrySpecial", Price = 150, Toppings = "Mushroom" };
            Pizza pizza2 = new Pizza() { Name = "farmHouse", Price = 150, Toppings = "Extra cheese" };
            Pizza pizza3 = new Pizza() { Name = "Chicken", Price = 250, Toppings = "Chicken" };
            Pizza pizza4 = new Pizza() { Name = "Regular", Price = 100, Toppings = "Mixture" };
            Menu menu = new Menu();
            menu.AddToMenu(pizza1);
            menu.AddToMenu(pizza2);
            menu.AddToMenu(pizza3);
            menu.AddToMenu(pizza4);
            Order order = new Order();
            order.AddInCart(pizza1);
            order.AddInCart(pizza2);
            Assert.AreEqual(2, order.CompleteOrder().Count);
          
        }
    }
}

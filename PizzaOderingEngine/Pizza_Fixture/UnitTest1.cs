using System;
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
        public void TO_Get_The_List_Ordered_Items()
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
            order.AddInCart(pizza3);
            Assert.AreEqual(3, order.CompleteOrder().Count);
            order.RemoveFromCart(pizza3);
            Assert.AreEqual(300, order.TotalBillAmount);
            Assert.AreEqual(true, order.CompleteOrder().Contains(pizza1));
            Assert.AreEqual(true, order.CompleteOrder().Contains(pizza2));
            Assert.AreEqual(false, order.CompleteOrder().Contains(pizza3));
        }
    }
}

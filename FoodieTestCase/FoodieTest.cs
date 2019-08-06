using System;
using Xunit;
using Foodie;

namespace FoodieTestCase
{
    public class FoodieTest
    {
        [Fact]
        public void AddFood()
        {
            Food pizza = new Pizza();
            MyCart cart = new MyCart();
            ViewCart viewCart;

            cart.Add(pizza, 3);
            viewCart = new ViewCart(cart.GetCurrentCart());

            Assert.Equal(3, viewCart.GetQuantity(pizza));
        }

        [Fact]
        public void TestTotalPrice()
        {
            Food pizza = new Pizza();
            MyCart cart = new MyCart();
            ViewCart viewCart;

            cart.Add(pizza, 3);
            viewCart = new ViewCart(cart.GetCurrentCart());

            Assert.Equal(300, viewCart.GetMealPrice(pizza));
        }

        [Fact]
        public void TestPlaceOrder()
        {
            Food pizza = new Pizza();
            MyCart cart = new MyCart();

            cart.Add(pizza, 2);
            Order order = new Order(cart, "cash");

            Assert.Equal(190, order.PlaceOrder());

        }
        [Fact]
        public void TestPlaceOrderByCash()
        {
            Food burger = new Burger();
            MyCart cart = new MyCart();
            IPayment payment = new CashPayment();

            cart.Add(burger, 4);
            Order order = new Order(cart, "cash");

            Assert.Equal(380, order.PlaceOrder());

        }

        [Fact]
        public void TestPlaceOrderByDebitCard()
        {
            Food burger = new Burger();
            MyCart cart = new MyCart();
            IPayment payment = new CashPayment();

            cart.Add(burger, 4);
            Order order = new Order(cart, "debitcard");

            Assert.Equal(360, order.PlaceOrder());

        }

        [Fact]
        public void TestPlaceOrderByOnlinePayment()
        {
            Food burger = new Burger();
            MyCart cart = new MyCart();
            IPayment payment = new CashPayment();

            cart.Add(burger, 4);
            Order order = new Order(cart, "onlinepayment");

            Assert.Equal(320, order.PlaceOrder());

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Foodie
{
    public class Order
    {
        private Dictionary<Food, int> _mealList = new Dictionary<Food, int>();
        IPayment _payment;
        public Order(MyCart cart, string payment)
        {
            this._mealList = cart.GetCurrentCart();
            this._payment = PaymentFactory.GetPaymentType(payment);
        }

        public double PlaceOrder()
        {
            double totalPrice = 0;
            foreach(var meal in _mealList)
            {
                totalPrice += _payment.DoPayment(meal.Key.Price) * meal.Value;
            }

            return totalPrice;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Foodie
{
    public class MyCart
    {
        private Dictionary<Food, int> _meal = new Dictionary<Food, int>();

        public void Add(Food food, int quantity)
        {
            if(_meal.ContainsKey(food))
            {
                _meal[food] = quantity;
            }
            else
            {
                _meal.Add(food, quantity);
            }
        }
        public Dictionary<Food, int> GetCurrentCart()
        {
            return _meal;
        }
    }
}

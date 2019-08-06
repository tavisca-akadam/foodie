using System.Collections.Generic;

namespace Foodie
{
    public class ViewCart
    {
        public Dictionary<Food, int> _meal = new Dictionary<Food, int>();
        public ViewCart(Dictionary<Food, int> meal)
        {
            this._meal = meal;
        }
        public int GetQuantity(Food food)
        {
            if (_meal.ContainsKey(food))
            {
                return _meal[food];
            }
            throw new KeyNotFoundException();
        }

        public int GetMealPrice(Food food)
        {
            int totalPrice = 0;
            if (_meal.ContainsKey(food))
            {
                totalPrice = food.Price * _meal[food];
            }
            else
                throw new KeyNotFoundException();
            return totalPrice;
        }
    }
}

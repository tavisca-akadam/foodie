namespace Foodie
{
    public class CashPayment : IPayment
    {
        public double DoPayment(int price)
        {
            return price - (price * 0.05);
        }
    }
}
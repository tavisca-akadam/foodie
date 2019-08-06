namespace Foodie
{
    public class DebitCardPayment : IPayment
    {
        public double DoPayment(int price)
        {
            return price - (price * 0.1);
        }
    }
}
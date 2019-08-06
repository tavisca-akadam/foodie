namespace Foodie
{
    public class OnlinePayment : IPayment
    {
        public double DoPayment(int price)
        {
            return price - (price * 0.2);
        }
    }
}
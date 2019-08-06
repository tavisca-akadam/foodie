using System;

namespace Foodie
{
    public class PaymentFactory
    {
        public static IPayment GetPaymentType(string paymentType)
        {
            switch(paymentType)
            {
                case "cash":
                    return new CashPayment();

                case "debitcard":
                    return new DebitCardPayment();

                case "onlinepayment":
                    return new OnlinePayment();

                default :
                    throw new NotImplementedException();
            }
        }
    }
}

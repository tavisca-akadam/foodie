using System;
using System.Collections.Generic;
using System.Text;

namespace Foodie
{
    public interface IPayment
    {
        double DoPayment(int price);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDecorator
{
    public abstract class ToppingsDecorator : Pizza
    {
        public abstract string getDescription();
    }
}

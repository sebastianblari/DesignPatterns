using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDecorator
{
    public class FreshTomato : ToppingsDecorator
    {
        Pizza pizza;
        FreshTomato(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override int getCost()
        {
            return pizza.getCost() + 40;
        }

        public override string getDescription()
        {
            return pizza.getDescription() + ", Fresh Tomato";
        }
    }

    public class FreshTomato : ToppingsDecorator
    {
        Pizza pizza;
        FreshTomato(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override int getCost()
        {
            return pizza.getCost() + 40;
        }

        public override string getDescription()
        {
            return pizza.getDescription() + ", Fresh Tomato";
        }
    }

    public class Paneer : ToppingsDecorator
    {
        Pizza pizza;
        Paneer(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override int getCost()
        {
            return pizza.getCost() + 70;
        }

        public override string getDescription()
        {
            return pizza.getDescription() + ", Paneer";
        }
    }

    public class Barbeque : ToppingsDecorator
    {
        Pizza pizza;
        Barbeque(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override int getCost()
        {
            return pizza.getCost() + 90;
        }

        public override string getDescription()
        {
            return pizza.getDescription() + ", Barbeque";
        }
    }
}

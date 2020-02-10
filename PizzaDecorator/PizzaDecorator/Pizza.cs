using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDecorator
{
    public abstract class Pizza
    {
        public string description = "Unknown Pizza";
        public string getDescription()
        {
            return description;
        }

        public abstract int getCost();
    }
}

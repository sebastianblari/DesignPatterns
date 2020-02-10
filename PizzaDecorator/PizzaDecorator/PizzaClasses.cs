using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDecorator
{
    class PeppyPaneer : Pizza
    {
        public PeppyPaneer()
        {
            description = "PeppyPaneer";
        }

        public override int getCost()
        {
            return 100;
        }
    }

    class ChickenFiesta : Pizza
    {
        public ChickenFiesta()
        {
            description = "ChickenFiesta";
        }

        public override int getCost()
        {
            return 200;
        }
    }

    class Margherita : Pizza
    {
        public Margherita()
        {
            description = "Margherita";
        }

        public override int getCost()
        {
            return 100;
        }
    }

    class FarmHouse : Pizza
    {
        public FarmHouse()
        {
            description = "FarmHouse";
        }

        public override int getCost()
        {
            return 200;
        }
    }

    class SimnplePizza : Pizza
    {
        public SimnplePizza()
        {
            description = "SimnplePizza";
        }

        public override int getCost()
        {
            return 50;
        }
    }
}

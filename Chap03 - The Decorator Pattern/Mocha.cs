using System;

namespace Chap03
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            BeverageDecorator = beverage;
        }

        public override string Description
        {
            get => BeverageDecorator.Description + ", Mocha";
            set => Description = value;
        }

        public override double Cost()
        {
            return BeverageDecorator.Cost() + .20;
        }
    }
}
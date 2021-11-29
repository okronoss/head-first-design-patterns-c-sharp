using System;

namespace Chap03
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            BeverageDecorator = beverage;
        }
        
        public override string Description
        {
            get => BeverageDecorator.Description + ", Soy";
            set => Description = value;
        }
        
        public override double Cost()
        {
            var cost = BeverageDecorator.Cost();

            cost += DrinkSize switch
            {
                Size.Tall => .10,
                Size.Grande => .15,
                Size.Venti => .20,
                _ => throw new ArgumentOutOfRangeException()
            };

            return cost;
        }
    }
}
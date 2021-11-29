namespace Chap03
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            BeverageDecorator = beverage;
        }
        
        public override string Description
        {
            get => BeverageDecorator.Description + ", Whip";
            set => Description = value;
        }
        
        public override double Cost()
        {
            return BeverageDecorator.Cost() + .10;
        }
    }
}
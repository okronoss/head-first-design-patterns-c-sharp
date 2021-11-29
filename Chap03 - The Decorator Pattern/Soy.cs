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
            return BeverageDecorator.Cost() + .15;
        }
    }
}
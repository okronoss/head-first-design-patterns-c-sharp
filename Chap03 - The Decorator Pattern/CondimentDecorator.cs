namespace Chap03
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage BeverageDecorator { get; set; }
        public override Size DrinkSize { get; set; }
    }
}
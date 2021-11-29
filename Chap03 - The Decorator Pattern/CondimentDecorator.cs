namespace Chap03
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage BeverageDecorator { get; set; }
    }
}
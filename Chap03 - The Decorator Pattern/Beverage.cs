namespace Chap03
{
    public abstract class Beverage
    {
        public enum Size
        {
            Tall,
            Grande,
            Venti
        }
        public virtual string Description { get; set; } = "Unknown Beverage";

        public virtual Size DrinkSize { get; set; } = Size.Tall;

        public abstract double Cost();

    }
}
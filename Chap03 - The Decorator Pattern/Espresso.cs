namespace Chap03
{
    public class Espresso : Beverage
    {
        public override string Description { get; set; } = "Espresso";

        public override double Cost()
        {
            return 1.99;
        }
    }
}
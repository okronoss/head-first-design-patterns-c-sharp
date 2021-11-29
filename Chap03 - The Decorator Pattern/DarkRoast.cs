namespace Chap03
{
    public class DarkRoast : Beverage
    {
        public override string Description { get; set; } = "Dark Roast Coffee";

        public override double Cost()
        {
            return .99;
        }
    }
}
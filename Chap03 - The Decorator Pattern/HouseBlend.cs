namespace Chap03
{
    public class HouseBlend : Beverage
    {
        public override string Description { get; set; } = "House Blend Coffee";

        public override double Cost()
        {
            return .89;
        }
    }
}
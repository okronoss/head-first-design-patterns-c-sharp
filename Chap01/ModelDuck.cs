using System;

namespace Chap01
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new RegularQuack();
        }
        public override IFlyBehavior FlyBehavior { get; set; }
        public override IQuackBehavior QuackBehavior { get; set; }
        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
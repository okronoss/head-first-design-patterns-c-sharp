using System;

namespace Chap01
{
    public class MallardDuck : Duck
    {
        public override IFlyBehavior FlyBehavior { get; set; }
        public override IQuackBehavior QuackBehavior { get; set; }

        public MallardDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new RegularQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
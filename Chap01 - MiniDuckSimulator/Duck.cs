using System;

namespace Chap01
{
    public abstract class Duck
    {
        public abstract IFlyBehavior FlyBehavior { get; set; }
        public abstract IQuackBehavior QuackBehavior { get; set; }
        
        public abstract void Display();

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
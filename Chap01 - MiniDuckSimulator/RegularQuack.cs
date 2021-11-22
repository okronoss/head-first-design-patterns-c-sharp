using System;

namespace Chap01
{
    public class RegularQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
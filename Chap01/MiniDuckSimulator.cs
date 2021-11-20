using System;

namespace Chap01
{
    class MiniDuckSimulator
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            
            mallard.PerformQuack();
            mallard.PerformFly();
        }
    }
}
using System;

namespace DesignPatterns.Decorator
{
    public class CheeseDecorator : BurritoDecoratorBase
    {
        public CheeseDecorator(IBurrito burritoBase) : base(burritoBase)
        {
        }

        public override void Description()
        {
            base.Description();
            Console.WriteLine("Cheese.");
        }
    }
}

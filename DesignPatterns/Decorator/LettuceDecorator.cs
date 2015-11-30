using System;

namespace DesignPatterns.Decorator
{
    public class LettuceDecorator : BurritoDecoratorBase
    {
        public LettuceDecorator(IBurrito burritoBase) : base(burritoBase)
        {
        }

        public override void Description()
        {
            base.Description();
            Console.WriteLine("Lettuce.");
        }
    }
}

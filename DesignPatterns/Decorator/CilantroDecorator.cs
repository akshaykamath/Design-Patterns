using System;

namespace DesignPatterns.Decorator
{
    public class CilantroDecorator : BurritoDecoratorBase
    {
        public CilantroDecorator(IBurrito burritoBase) : base(burritoBase)
        {
        }

        public override void Description()
        {
            base.Description();
            Console.WriteLine("Cilantro.");
        }
    }
}

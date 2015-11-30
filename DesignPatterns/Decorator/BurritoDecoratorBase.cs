
namespace DesignPatterns.Decorator
{
    public abstract class BurritoDecoratorBase : IBurrito
    {
        private IBurrito BurritoBase { get; set; }

        public BurritoDecoratorBase(IBurrito burritoBase) : base()
        {
            BurritoBase = burritoBase;
        }

        public virtual void Description()
        {
            BurritoBase.Description();
        }
    }
}

using DesignPatterns.AbstractFactory.AbstractFactory;
using DesignPatterns.AbstractFactory.AbstractProducts;
using DesignPatterns.AbstractFactory.ConcreteProducts;

namespace DesignPatterns.AbstractFactory.ConcreteFactories
{
    public class ChocolateCakeFactory : IAbstractCakeFactory
    {
        public ICakeBase CakeBase()
        {
            return new ChocolateCakeBase();
        }

        public ICakeTopping CakeTopping()
        {
            return new ChocolateCakeTopping();
        }
    }
}

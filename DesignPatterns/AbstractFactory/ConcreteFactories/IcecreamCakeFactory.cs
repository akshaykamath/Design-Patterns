using DesignPatterns.AbstractFactory.AbstractFactory;
using DesignPatterns.AbstractFactory.AbstractProducts;
using DesignPatterns.AbstractFactory.ConcreteProducts;

namespace DesignPatterns.AbstractFactory.ConcreteFactories
{
    public class IcecreamCakeFactory : IAbstractCakeFactory
    {
        public ICakeBase CakeBase()
        {
            return new IcecreamCakeBase();
        }

        public ICakeTopping CakeTopping()
        {
            return new IcecreamCakeTopping();
        }
    }
}
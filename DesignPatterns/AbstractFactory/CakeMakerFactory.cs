using DesignPatterns.AbstractFactory.AbstractFactory;
using DesignPatterns.AbstractFactory.ConcreteFactories;

namespace DesignPatterns.AbstractFactory
{
    /// <summary>
    /// A factory that returns a factory.
    /// </summary>
    public class CakeMakerFactory 
    {
        private static readonly CakeMakerFactory _instance = new CakeMakerFactory();

        private CakeMakerFactory()
        {
        }

        public static CakeMakerFactory Instance
        {
            get { return _instance; }
        }

        public IAbstractCakeFactory GetCakeFactory(DpConstants.CakeFactories factoryType)
        {
            IAbstractCakeFactory cakeFactory = null;

            switch (factoryType)
            {
                case DpConstants.CakeFactories.ChocolateCakeFactory:
                    cakeFactory = new ChocolateCakeFactory();
                    break;
                case DpConstants.CakeFactories.IcecreamCakeFactory:
                    cakeFactory = new IcecreamCakeFactory();
                    break;
                default:
                    cakeFactory = new IcecreamCakeFactory();
                    break;
            }

            return cakeFactory;

        }
    }
}


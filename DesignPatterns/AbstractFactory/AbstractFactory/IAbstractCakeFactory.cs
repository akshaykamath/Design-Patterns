using DesignPatterns.AbstractFactory.AbstractProducts;

namespace DesignPatterns.AbstractFactory.AbstractFactory
{
    public interface IAbstractCakeFactory
    {
        ICakeBase CakeBase();

        ICakeTopping CakeTopping();
    }
}

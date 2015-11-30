using DesignPatterns.AbstractFactory.AbstractProducts;
using System;

namespace DesignPatterns.AbstractFactory.ConcreteProducts
{
    class IcecreamCakeTopping : ICakeTopping
    {
        public void MakeCakeTopping()
        {
            Console.WriteLine("Prepared Icecream cake topping.");
        }
    }
}

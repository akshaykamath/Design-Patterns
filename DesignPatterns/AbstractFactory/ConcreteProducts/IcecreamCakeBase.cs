using System;
using DesignPatterns.AbstractFactory.AbstractProducts;

namespace DesignPatterns.AbstractFactory.ConcreteProducts
{
    class IcecreamCakeBase : ICakeBase
    {
        public void MakeCakeBase()
        {
            Console.WriteLine("Ice cream cake ready");
        }
    }
}

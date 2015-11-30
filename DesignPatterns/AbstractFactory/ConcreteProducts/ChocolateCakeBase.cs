using System;
using DesignPatterns.AbstractFactory.AbstractProducts;

namespace DesignPatterns.AbstractFactory.ConcreteProducts
{
    class ChocolateCakeBase : ICakeBase
    {
        public void MakeCakeBase()
        {
            Console.WriteLine("Chocolate Cake Ready");
        }
    }
}

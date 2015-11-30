using System;
using DesignPatterns.AbstractFactory.AbstractProducts;

namespace DesignPatterns.AbstractFactory.ConcreteProducts
{
    class ChocolateCakeTopping : ICakeTopping
    {
        public void MakeCakeTopping()
        {
            Console.WriteLine("Prepared choclate cake topping.");
        }
    }
}

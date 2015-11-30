using System;
using DesignPatterns.Singleton;
using DesignPatterns.Factory;
using DesignPatterns.AbstractFactory.AbstractFactory;
using DesignPatterns.AbstractFactory.AbstractProducts;
using DesignPatterns.AbstractFactory;
using DesignPatterns.Decorator;
using DesignPatterns.TemplateMethod;

namespace DesignPatterns
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            // TestAbstractFactory();
            // TestDecorator();
            TestTemplateMethod();
        }

        private static void InvokeSingleton()
        {
            SingletonTester.Instance.TestMethod("Print Me!!");
        }

        private static void TestFactory()
        {
            IDevice device =  DeviceFactory.Instance.GetDevice(DpConstants.Devices.Television);
            device.TurnOn();
            device.PerformActivities();
            device.TurnOff();
        }

        private static void TestAbstractFactory()
        {
            // Change the enum to change the factory and products!!
            IAbstractCakeFactory iceCreamCakeFactory = CakeMakerFactory.Instance.GetCakeFactory(DpConstants.CakeFactories.ChocolateCakeFactory);
            ICakeBase cakeBase = iceCreamCakeFactory.CakeBase();
            ICakeTopping cakeTopping = iceCreamCakeFactory.CakeTopping();

            cakeBase.MakeCakeBase();
            cakeTopping.MakeCakeTopping();
            Console.ReadLine();
        }

        private static void TestDecorator()
        {
            IBurrito burrito = new Burrito();

            burrito = new LettuceDecorator(burrito);
            burrito = new CilantroDecorator(burrito);
            burrito = new CheeseDecorator(burrito);
                        
            burrito.Description();
            Console.ReadLine();
        }

        private static void TestTemplateMethod()
        {
            RecipeBase recipe = new CakeRecipe();
            recipe.PrepareDish();
            Console.ReadLine();
        }
    }
}

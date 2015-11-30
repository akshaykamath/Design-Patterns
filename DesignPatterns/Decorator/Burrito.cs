using System;

namespace DesignPatterns.Decorator
{
    class Burrito : IBurrito
    {
        public void Description()
        {
            Console.WriteLine("Burrito.");
        }
    }
}

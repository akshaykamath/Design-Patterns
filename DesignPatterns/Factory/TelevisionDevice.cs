using System;

namespace DesignPatterns.Factory
{
    class TelevisionDevice : IDevice
    {
        public void PerformActivities()
        {
            Console.WriteLine("Television Actions");
            Console.ReadLine();
        }

        public void TurnOff()
        {
            Console.WriteLine("Television Turned Off.");
            Console.ReadLine();
        }

        public void TurnOn()
        {
            Console.WriteLine("Television Turned On.");
            Console.ReadLine();
        }
    }
}

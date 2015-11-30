using System;

namespace DesignPatterns.Factory
{
    class RadioDevice : IDevice
    {
        public void PerformActivities()
        {
            Console.WriteLine("Radio Actions");
            Console.ReadLine();
        }

        public void TurnOff()
        {
            Console.WriteLine("Radio Turned Off.");
            Console.ReadLine();
        }

        public void TurnOn()
        {
            Console.WriteLine("Radio Turned On.");
            Console.ReadLine();
        }
    }
}

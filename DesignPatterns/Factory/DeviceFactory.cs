
namespace DesignPatterns.Factory
{
    public class DeviceFactory
    {        
        private static readonly DeviceFactory _instance = new DeviceFactory();

        private DeviceFactory()
        {
        }

        public static DeviceFactory Instance
        {
            get { return _instance; }
        }

        public IDevice GetDevice(DpConstants.Devices deviceType)
        {
            IDevice device = null;

            switch (deviceType)
            {
                case DpConstants.Devices.Television:
                    device = new TelevisionDevice();
                    break;
                case DpConstants.Devices.Radio:
                    device = new RadioDevice();
                    break;
                default:
                    device = new RadioDevice();
                    break;
            }

            return device;

        }
    }
}

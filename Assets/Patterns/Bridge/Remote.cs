
namespace Personal.Patterns.Bridge
{
    // The "abstraction" defines the interface for the "control" part of the two class hierarchies.
    // It maintains a reference to an object of the "implementation" hierarchy and delegates all of the real work to this object.
    public class Remote
    {
        protected IDevice _device;

        public Remote(IDevice device)
        {
            _device = device;
        }

        public void TogglePower()
        {
            if(_device.IsEnabled())
            {
                _device.Disable();
            }
            else
            {
                _device.Enable();
            }
        }

        public void SetVolumeDown()
        {
            _device.SetVolume(_device.GetVolume() - 10);
        }

        public void SetVolumeUp()
        {
            _device.SetVolume(_device.GetVolume() + 10);
        }

        public void SetChannelDown()
        {
            _device.SetChannel(_device.GetChannel() - 1);
        }

        public void SetChannelUp()
        {
            _device.SetChannel(_device.GetChannel() + 1);
        }
    }
}
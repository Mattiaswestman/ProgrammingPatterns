
namespace Personal.Patterns.Bridge
{
    // AdvancedRemote is optional.
    // Classes can be extended from the abstraction hierarchy independently from device classes.
    public class AdvancedDevice : Remote
    {
        public AdvancedDevice(IDevice device) : base(device)
        {
            _device = device;
        }

        public void Mute()
        {
            _device.SetVolume(0);
        }
    }
}
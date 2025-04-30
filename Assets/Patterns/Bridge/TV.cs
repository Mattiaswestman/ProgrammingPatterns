using UnityEngine;

namespace Personal.Patterns.Bridge
{
    // All devices follow the same interface.
    public class TV : IDevice
    {
        private int _volume = 50;
        private int _channel = 1;
        private bool _isEnabled;

        public bool IsEnabled()
        {
            return _isEnabled;
        }

        public void Enable()
        {
            _isEnabled = true;
            Debug.Log($"TV, Enabled: {_isEnabled}.");
        }

        public void Disable()
        {
            _isEnabled = false;
            Debug.Log($"TV, Enabled: {_isEnabled}.");
        }

        public int GetVolume()
        {
            return _volume;
        }

        public void SetVolume(int volume)
        {
            _volume = Mathf.Clamp(volume, 0, 100);
            Debug.Log($"TV, Volume: {_volume}");
        }

        public int GetChannel()
        {
            return _channel;
        }

        public void SetChannel(int channel)
        {
            _channel = Mathf.Clamp(channel, 1, 50);
            Debug.Log($"TV, Channel: {_channel}");
        }
    }
}
using UnityEngine;

namespace Personal.Patterns.Bridge
{
    // All devices follow the same interface.
    public class Radio : IDevice
    {
        private int _volume;
        private int _channel;
        private bool _isEnabled;

        public bool IsEnabled()
        {
            return _isEnabled;
        }

        public void Enable()
        {
            _isEnabled = true;
            Debug.Log($"Radio, Enabled: {_isEnabled}.");
        }

        public void Disable()
        {
            _isEnabled = false;
            Debug.Log($"Radio, Enabled: {_isEnabled}.");
        }

        public int GetVolume()
        {
            return _volume;
        }

        public void SetVolume(int volume)
        {
            _volume = Mathf.Clamp(volume, 0, 100);
            Debug.Log($"Radio, Volume: {_volume}");
        }

        public int GetChannel()
        {
            return _channel;
        }

        public void SetChannel(int channel)
        {
            _channel = Mathf.Clamp(channel, 1, 50);
            Debug.Log($"Radio, Channel: {_channel}");
        }
    }
}
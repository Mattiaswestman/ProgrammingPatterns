using UnityEngine;

namespace Personal.Patterns.Bridge
{
    public class DemoController : MonoBehaviour
    {
        private Radio _radio;
        private TV _tv;

        private Remote _radioRemote;
        private Remote _tvRemote;
        private Remote _activeRemote;

        private void Awake()
        {
            _radio = new Radio();
            _tv = new TV();

            _radioRemote = new Remote(_radio);
            _tvRemote = new Remote(_tv);
            _activeRemote = _radioRemote;

            Debug.Log("Press '1' to use radio remote and '2' to use tv remote.");
            Debug.Log("Press '3' to toggle power.");
            Debug.Log("Press '4' to lower volume and '5' to raise volume.");
            Debug.Log("Press '6' to lower channel and '7' to raise channel.");
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                _activeRemote = _radioRemote;
                Debug.Log("Changed to radio remote.");
            }
            else if(Input.GetKeyDown(KeyCode.Alpha2))
            {
                _activeRemote = _tvRemote;
                Debug.Log("Changed to tv remote.");
            }
            else if(Input.GetKeyDown(KeyCode.Alpha3))
            {
                _activeRemote.TogglePower();
            }
            else if(Input.GetKeyDown(KeyCode.Alpha4))
            {
                _activeRemote.SetVolumeDown();
            }
            else if(Input.GetKeyDown(KeyCode.Alpha5))
            {
                _activeRemote.SetVolumeUp();
            }
            else if(Input.GetKeyDown(KeyCode.Alpha6))
            {
                _activeRemote.SetChannelDown();
            }
            else if(Input.GetKeyDown(KeyCode.Alpha7))
            {
                _activeRemote.SetChannelUp();
            }
        }
    }
}
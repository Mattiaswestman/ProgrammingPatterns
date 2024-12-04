using UnityEngine;

namespace Personal.Patterns.Decorator
{
    public class SlackNotifier
    {
        public void SendMessage()
        {
            Debug.Log("Sending slack message.");
        }
    }
}
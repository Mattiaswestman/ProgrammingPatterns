using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Personal.Patterns.Decorator
{
    public class DemoController : MonoBehaviour
    {
        private SmsNotifier _smsNotifier;
        private FacebookNotifier _facebookNotifier;
        private SlackNotifier _slackNotifier;

        private void Awake()
        {
            _smsNotifier = new SmsNotifier();
            _facebookNotifier = new FacebookNotifier();
            _slackNotifier = new SlackNotifier();
        }

        private void Update()
        {
            HandleInput();
        }

        private void HandleInput()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                _smsNotifier.SendMessage();
            }
        }
    }
}
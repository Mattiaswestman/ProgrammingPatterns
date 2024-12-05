using System;
using System.Collections.Generic;
using UnityEngine;

namespace Personal.Patterns.Observer
{
    public class Subject : MonoBehaviour
    {
        public event Action EventRaised;

        private void Update()
        {
            HandleInput();
        }

        public void Subscribe(IObserver observer)
        {
            EventRaised += observer.OnEventRaised;
        }

        public void Unsubscribe(IObserver observer)
        {
            EventRaised -= observer.OnEventRaised;
        }

        public void RaiseEvent()
        {
            EventRaised?.Invoke();
        }

        private void HandleInput()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                RaiseEvent();
            }
        }
    }
}
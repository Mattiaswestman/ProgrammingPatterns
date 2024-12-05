using UnityEngine;

namespace Personal.Patterns.Observer
{
    public class Observer : MonoBehaviour, IObserver
    {
        [SerializeField]
        private Subject _subject;
        [SerializeField]
        private bool _subscribeToSubject = true;

        private void Awake()
        {
            if((_subject != null) && (_subscribeToSubject))
            {
                _subject.Subscribe(this);
            }
        }

        private void OnDestroy()
        {
            if((_subject != null) && (_subscribeToSubject))
            {
                _subject.Unsubscribe(this);
            }
        }

        public void OnEventRaised()
        {
            Debug.Log($"Observer '{gameObject.name}' was notified of event.");
        }
    }
}
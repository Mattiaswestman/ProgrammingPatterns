using UnityEngine;

/// <summary>
/// Singleton is a creational design pattern that lets you ensure that a class has only one instance, 
/// while providing a global access point to this instance.
/// </summary>

namespace Personal.Patterns
{
    public class Singleton<T> : MonoBehaviour where T : Component
    {
        public static T Instance { get; private set; }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this as T;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
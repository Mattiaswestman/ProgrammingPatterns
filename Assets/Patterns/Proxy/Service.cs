using UnityEngine;

namespace Personal.Patterns.Proxy
{
    // The Service is a class that provides some useful business logic.
    public class Service : MonoBehaviour, IServiceInterface
    {
        public void PrintLog()
        {
            Debug.Log("Service is doing work.");
        }
    }
}
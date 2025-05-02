using System;
using System.Collections;
using UnityEngine;

namespace Personal.Patterns.Proxy
{
    // The Proxy class has a reference field that points to a service object. After the proxy finishes its processing, it passes the request to the service object.
    // This example displays access control, but proxies can also handle stuff like lazy initialization, logging, caching, etc.
    public class Proxy : MonoBehaviour, IServiceInterface
    {
        private readonly Service _service;
        private DateTime _lastAccessTime;

        public Proxy(Service service)
        {
            _service = service;
        }

        public void PrintLog()
        {
            if((_lastAccessTime != default) && (DateTime.Now - _lastAccessTime).Seconds <= 5)
            {
                Debug.Log("Access to Service restricted. Wait 5 seconds between each call.");
                return;
            }

            _service.PrintLog();
            _lastAccessTime = DateTime.Now;
        }
    }
}
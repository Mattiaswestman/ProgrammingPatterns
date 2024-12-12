using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Personal.Patterns.Command
{
    public class Receiver : MonoBehaviour
    {
        public void PrintLog(string log)
        {
            Debug.Log(log);
        }
    }
}
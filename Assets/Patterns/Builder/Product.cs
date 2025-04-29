using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Personal.Patterns.Builder
{
    public class Product
    {
        private string _stringValue;
        private int _intValue;
        private bool _boolValue;

        public void PrintLog()
        {
            Debug.Log($"Product Info, String: {_stringValue}, Int: {_intValue}, Bool: {_boolValue}");
        }

        public void SetString(string value)
        {
            _stringValue = value;
        }

        public void SetInt(int value)
        {
            _intValue = value;
        }

        public void SetBool(bool value)
        {
            _boolValue = value;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Personal.Patterns.Builder
{
    public interface IBuilder
    {
        public void Reset();
        public void BuildStepA(string value);
        public void BuildStepB(int value);
        public void BuildStepC(bool value);
    }
}
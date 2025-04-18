using UnityEngine;

namespace Personal.Patterns.AbstractFactory
{
    public class DemoController : MonoBehaviour
    {
        private IAbstractFactory _abstractFactory;

        private void Awake()
        {
            _abstractFactory = new MinorItemFactory();

            Debug.Log("Press '1' to set minor items factory.");
            Debug.Log("Press '2' to set major items factory.");
            Debug.Log("Press '3' to create health boost.");
            Debug.Log("Press '4' to create damage boost.");
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                _abstractFactory = new MinorItemFactory();
            }
            else if(Input.GetKeyDown(KeyCode.Alpha2))
            {
                _abstractFactory = new MajorItemFactory();
            }
            else if(Input.GetKeyDown(KeyCode.Alpha3))
            {
                IHealthBoost healthBoost = _abstractFactory.GetHealthBoost();
                healthBoost.PrintLog();
            }
            else if(Input.GetKeyDown(KeyCode.Alpha4))
            {
                IDamageBoost damageBoost = _abstractFactory.GetDamageBoost();
                damageBoost.PrintLog();
            }
        }
    }
}
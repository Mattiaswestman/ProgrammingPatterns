using UnityEngine;

namespace Personal.Patterns.SOLID.SingleResponsibility
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField]
        private float _positionMultiplier;
        
        private float _yPosition;

        private void Update()
        {
            transform.position = new Vector3(transform.position.x, _yPosition * _positionMultiplier, transform.position.z);
        }
    }
}

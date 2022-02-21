using FSLib.FSGlobalVariables;
using UnityEngine;

namespace Player
{
    public class PlayerForwardRightMove : MonoBehaviour
    {
        private Transform _transform;
        private Rigidbody _rigidbody;
        [SerializeField] private FsGlobalFloatSo speed;
        [SerializeField] private FsGlobalBoolSo isMoving;
        [SerializeField] private FsGlobalVector3So direction;
        
        private void Awake()
        {
            _transform = transform;
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            //TODO Rework inputs
            direction.Value = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            isMoving.Value = direction.Value != Vector3.zero;
        }

        private void FixedUpdate()
        {
            _rigidbody.MovePosition(_transform.position + _transform.TransformDirection(direction.Value) * (speed.Value * Time.deltaTime));
        }
    }
}

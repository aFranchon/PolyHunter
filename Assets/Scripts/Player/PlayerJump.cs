using FSLib.FSEvents.SO;
using FSLib.FSGlobalVariables;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerJump : MonoBehaviour
    {
        private Rigidbody _rigidbody;

        [SerializeField] private FsVoidEventSo onJump;
        
        [SerializeField] private float jumpForce;
        private bool _jumped;
        [SerializeField] private FsGlobalBoolSo grounded;

        private int _groundCollided;
        
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            //TODO rework inputs
            if (!_jumped && grounded.Value && Input.GetKeyDown(KeyCode.Space))
                _jumped = true;
        }

        private void FixedUpdate()
        {
            if (!_jumped) return;

            onJump.Invoke();
            _jumped = false;
            _rigidbody.velocity = Vector3.zero;
            _rigidbody.angularVelocity = Vector3.zero;
            _rigidbody.AddForce(Vector3.up * jumpForce);
        }
        
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.layer != 9) return;
            
            grounded.Value = true;
            _groundCollided++;
        }
        
        private void OnCollisionExit(Collision other)
        {
            if (other.gameObject.layer != 9) return;
            
            _groundCollided--;
            
            if (_groundCollided > 0f) return;
            grounded.Value = false;
        }
    }
}

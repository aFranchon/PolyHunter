using FSLib.FSGlobalVariables;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(PlayerJump))]
    public class PlayerBetterJump : MonoBehaviour
    {
        [SerializeField] private float fallMultiplier = 2.5f;
        [SerializeField] private float lowJumpMultiplier = 2.5f;
        [SerializeField] private FsGlobalBoolSo isGrounded;

        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            //TODO rework inputs
            if (_rigidbody.velocity.y < 0 && !isGrounded.Value)
            {
                _rigidbody.velocity += Vector3.up * (Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime);
            }
            else if (_rigidbody.velocity.y > 0 && !Input.GetButton("Jump"))
            {
                _rigidbody.velocity += Vector3.up * (Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime);
            }
        }
    }
}

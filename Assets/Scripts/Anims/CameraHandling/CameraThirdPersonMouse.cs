using UnityEngine;

namespace CameraHandling
{
    public class CameraThirdPersonMouse : MonoBehaviour
    {
        private Transform _transform;
        
        [SerializeField] private float mouseSensitivity;
        [SerializeField] private Transform target;
        [SerializeField] private float offset;
        [SerializeField] private Vector2 pitchMinMax;
        [SerializeField] private float rotationSmoothTime;

        private Vector3 _rotationSmoothVelocity;
        private Vector3 _currentRotation;
        private Vector3 _currentTargetRotation;

        private float _yaw;
        private float _pitch;

        private void Awake()
        {
            _transform = transform;
        }

        private void Update()
        {
            _yaw = Input.GetAxis("Mouse X") * mouseSensitivity;
        }

        private void LateUpdate()
        {
            //_pitch -= Input.GetAxis("Mouse Y") * mouseSensitivity;
            //_pitch = Mathf.Clamp(_pitch, pitchMinMax.x, pitchMinMax.y);
            
            //_transform.eulerAngles = new Vector3(_pitch, 0, 0);

            target.Rotate(new Vector3(0, _yaw, 0));
        }
    }
}

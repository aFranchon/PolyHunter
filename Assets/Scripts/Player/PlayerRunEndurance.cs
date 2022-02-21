using FSLib.FSGlobalVariables;
using UnityEngine;

namespace Player
{
    public class PlayerRunEndurance : MonoBehaviour
    {
        [SerializeField] private FsGlobalBoolSo isMoving;
        [SerializeField] private FsGlobalFloatSo speed;
        [SerializeField] private float runningSpeed = 20;
        private float _baseSpeed;
        [SerializeField] private float maxEndurance = 3f;
        private float _currentEndurance;
        private bool _isRunning;

        private bool IsRunning
        {
            set
            {
                _isRunning = value;
                speed.Value = value ? runningSpeed : _baseSpeed;
            }
        }

        private void Awake()
        {
            _currentEndurance = maxEndurance;
            isMoving.OnValueUpdate += OnPlayerMovingValueChanged;
            _baseSpeed = speed.Value;
        }

        private void OnPlayerMovingValueChanged()
        {
            if (isMoving.Value || !_isRunning) return;

            IsRunning = false;
        }
        
        private void Update()
        {
            _currentEndurance = _isRunning ? 
                Mathf.Max(_currentEndurance - Time.deltaTime, 0)
                : Mathf.Min(_currentEndurance + Time.deltaTime, maxEndurance);

            if (_currentEndurance <= 0f)
                IsRunning = false;

            //TODO rework inputs
            if (_isRunning || !isMoving.Value || !(_currentEndurance >= .5f) || !Input.GetKeyDown(KeyCode.LeftShift)) return;
            
            IsRunning = true;
        }

        private void OnDestroy()
        {
            isMoving.OnValueUpdate -= OnPlayerMovingValueChanged;
            speed.Value = _baseSpeed;
        }
    }
}

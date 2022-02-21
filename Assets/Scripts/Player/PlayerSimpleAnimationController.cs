using System;
using FSLib.FSGlobalVariables;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Animator))]
    public class PlayerSimpleAnimationController : MonoBehaviour
    {
        [SerializeField] private FsGlobalBoolSo isRunning;

        private Animator _animator;
        
        private static readonly int IsRunning = Animator.StringToHash("IsRunning");
        private static readonly int Jump = Animator.StringToHash("Jump");
        private static readonly int IsRunningBackward = Animator.StringToHash("IsRunningBackward");
        private static readonly int IsRunningRight = Animator.StringToHash("IsRunningRight");
        private static readonly int IsRunningLeft = Animator.StringToHash("IsRunningLeft");

        private void Awake()
        {
            _animator = GetComponent<Animator>();
            isRunning.OnValueUpdate += OnIsRunningValueUpdate;
        }

        private void OnIsRunningValueUpdate()
        {
            //TODO do something with abckward/forward
            _animator.SetBool(IsRunning, isRunning.Value);
        }

        public void OnJump()
        {
            //TODO rework this to have a great jump
            _animator.SetTrigger(Jump);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.D)) _animator.SetBool(IsRunningRight, true);
            if (Input.GetKeyDown(KeyCode.Q)) _animator.SetBool(IsRunningLeft, true);
            if (Input.GetKeyUp(KeyCode.D)) _animator.SetBool(IsRunningRight, false);
            if (Input.GetKeyUp(KeyCode.Q)) _animator.SetBool(IsRunningLeft, false);
            if (Input.GetKeyDown(KeyCode.S)) _animator.SetBool(IsRunningBackward, true);
            if (Input.GetKeyUp(KeyCode.S)) _animator.SetBool(IsRunningBackward, false);
        }
    }
}

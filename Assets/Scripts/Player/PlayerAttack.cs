using FSLib.FSEvents.SO;
using UnityEngine;

namespace Player
{
    public class PlayerAttack : MonoBehaviour
    {
        private Animator _animator;
        private static readonly int SwordSlash = Animator.StringToHash("SwordSlash");

        private bool _hasAttacked;

        [SerializeField] private FsVoidEventSo onAnimationHit;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        private void Update()
        {
            if (_hasAttacked || Input.GetAxis("Fire1") <= 0.1f) return;

            _hasAttacked = true;
            _animator.SetTrigger(SwordSlash);
        }

        public void OnAnimationHit()
        {
            onAnimationHit.Invoke();
        }

        public void OnAttackEnded()
        {
            _hasAttacked = false;
        }
    }
}

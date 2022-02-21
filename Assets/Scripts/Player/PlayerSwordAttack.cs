using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerSwordAttack : MonoBehaviour
    {
        private readonly List<GameObject> _collided = new List<GameObject>();

        public void OnAnimationHit()
        {
            foreach (var o in _collided)
            {
                Destroy(o);
            }
            _collided.Clear();
        }
    
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.layer != 10) return; // Destroyable layer
            _collided.Add(other.gameObject);
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.layer != 10) return; // Destroyable layer
            _collided.Remove(other.gameObject);
        }
    }
}

using FSLib.FSEvents.SO;
using UnityEngine;

namespace GameBehaviour
{
    public class GameEndTrigger : MonoBehaviour
    {
        [SerializeField] private GameObject[] anims;
        [SerializeField] private FsVoidEventSo onEndTriggered;
        
        private void OnEnable()
        {
            foreach (var anim in anims)
            {
                anim.SetActive(true);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (!enabled) return;
            if (other.gameObject.layer != 8) return; //player layer
            
            onEndTriggered.Invoke();
        }
    }
}

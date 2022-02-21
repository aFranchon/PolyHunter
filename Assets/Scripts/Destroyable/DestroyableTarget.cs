using FSLib.FSEvents.SO;
using UnityEngine;

namespace Destroyable
{
    public class DestroyableTarget : MonoBehaviour
    {
        [SerializeField] private int id;
        //TODO Change to int
        [SerializeField] private FsVoidEventSo onTargetDestroyed;
        
        private void OnDestroy()
        {
            onTargetDestroyed.Invoke();
        }
    }
}

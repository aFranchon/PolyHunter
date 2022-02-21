using FSLib.FSGlobalVariables;
using UnityEngine;

namespace Lock
{
    public class LockedObject : MonoBehaviour
    {
        [SerializeField] private FsGlobalBoolSo locked;
        [SerializeField] private MonoBehaviour lockedObject;

        private void Awake()
        {
            lockedObject.enabled = false;
            locked.OnValueUpdate += OnLockedValueUpdate;
        }

        private void OnLockedValueUpdate()
        {
            if (locked.Value) return;

            lockedObject.enabled = true;
        }

        private void OnDisable()
        {
            locked.OnValueUpdate -= OnLockedValueUpdate;
        }
    }
}

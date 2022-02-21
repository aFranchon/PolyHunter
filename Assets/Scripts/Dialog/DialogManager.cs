using FSLib.FSGlobalVariables;
using UnityEngine;

namespace Dialog
{
    public class DialogManager : MonoBehaviour
    {
        [SerializeField] private FsGlobalGameObjectSo dialogGameObject;

        [SerializeField] private GameObject dialog;

        private void Awake()
        {
            dialogGameObject.Value = dialog;
        }
    }
}

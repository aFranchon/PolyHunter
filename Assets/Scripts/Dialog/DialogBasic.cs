using FSLib.FSGlobalVariables;
using UnityEngine;

namespace Dialog
{
    public class DialogBasic : MonoBehaviour
    {
        [SerializeField] private string dialog;
        [SerializeField] private int avatarIndex;

        [SerializeField] private FsGlobalListGameObjectSo avatars;
        [SerializeField] private FsGlobalGameObjectSo dialogGameObject;
        [SerializeField] private FsGlobalStringSo textString;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.layer != 8) return;// Player layer
            if (dialogGameObject.Value.activeSelf) return;

            dialogGameObject.Value.SetActive(true);
            avatars.Value[avatarIndex].SetActive(true);
            textString.Value = dialog;
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.layer != 8) return;// Player layer
            if (!avatars.Value[avatarIndex].activeSelf) return;
            
            avatars.Value[avatarIndex].SetActive(false);
            dialogGameObject.Value.SetActive(false);
        }
    }
}

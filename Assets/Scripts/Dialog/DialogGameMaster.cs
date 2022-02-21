using System.Collections;
using FSLib.FSGlobalVariables;
using UnityEngine;

namespace Dialog
{
    public class DialogGameMaster : MonoBehaviour
    {
        [SerializeField] private string[] dialogs;

        [SerializeField] private FsGlobalListGameObjectSo avatars;
        [SerializeField] private FsGlobalGameObjectSo dialogGameObject;
        [SerializeField] private FsGlobalStringSo textString;

        [SerializeField] private int avatarIndex;
        private int _index;

        private Coroutine _coroutine;
        
        private void Start()
        {
            _coroutine = StartCoroutine(NextDialog(15f));
        }

        private IEnumerator NextDialog(float timeToWait)
        {
            dialogGameObject.Value.SetActive(true);
            foreach (var avatar in avatars.Value)
            {
                avatar.SetActive(false);
            }
            avatars.Value[avatarIndex].SetActive(true);
            textString.Value = dialogs[_index];
            _index++;

            yield return new WaitForSeconds(timeToWait);
            
            dialogGameObject.Value.SetActive(false);
            avatars.Value[avatarIndex].SetActive(false);
        }

        public void OnItemDestroyed()
        {
            if (_index >= dialogs.Length) return;
            
            var wait = 3f;
            if (_index == dialogs.Length - 1)
                wait = 7f;

            StopCoroutine(_coroutine);
            _coroutine = StartCoroutine(NextDialog(wait));
        }
    }
}

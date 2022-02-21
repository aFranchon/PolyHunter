using System.Collections.Generic;
using FSLib.FSGlobalVariables;
using UnityEngine;

namespace Dialog
{
    public class DialogAvatarManager : MonoBehaviour
    {
        [SerializeField] private FsGlobalListGameObjectSo avatars;

        [SerializeField] private List<GameObject> avatarsList = new List<GameObject>();
        
        private void Awake()
        {
            avatars.Value = avatarsList;
        }
    }
}

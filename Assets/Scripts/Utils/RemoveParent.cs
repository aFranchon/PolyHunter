using UnityEngine;

namespace Utils
{
    public class RemoveParent : MonoBehaviour
    {
        public void OnEvent()
        {
            transform.parent = null;
        }
    }
}

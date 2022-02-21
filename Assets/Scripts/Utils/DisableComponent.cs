using UnityEngine;

namespace Utils
{
    public class DisableComponent : MonoBehaviour
    {
        [SerializeField] private MonoBehaviour component;

        public void OnEvent()
        {
            component.enabled = false;
        }
    }
}

using UnityEngine;

namespace Utils
{
    public class ShowGameObject : MonoBehaviour
    {
        [SerializeField] private GameObject _gameObject;
        
        public void OnEvent()
        {
            _gameObject.SetActive(true);
        }
    }
}

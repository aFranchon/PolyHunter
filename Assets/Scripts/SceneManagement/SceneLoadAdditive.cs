using UnityEngine;
using UnityEngine.SceneManagement;

namespace SceneManagement
{
    public class SceneLoadAdditive : MonoBehaviour
    {
        [SerializeField] private int[] sceneIndexes;
        
        private void Awake()
        {
            foreach (var index in sceneIndexes)
            {
                SceneManager.LoadSceneAsync(index, LoadSceneMode.Additive);
            }
        }
    }
}

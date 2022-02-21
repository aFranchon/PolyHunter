using DG.Tweening;
using UnityEngine;

namespace Anims
{
    public class AnimUpDown : MonoBehaviour
    {
        private void Start()
        {
            transform.DOMoveY(.25f, 2f)
                .SetRelative(true)
                .SetEase(Ease.InOutCubic)
                .SetLoops(-1, LoopType.Yoyo);
        }
        
        private void OnDestroy()
        {
            transform.DOKill();
        }
    }
}

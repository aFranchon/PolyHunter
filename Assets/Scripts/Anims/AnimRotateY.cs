using DG.Tweening;
using UnityEngine;

namespace Anims
{
    public class AnimRotateY : MonoBehaviour
    {
        private void Awake()
        {
            transform.DOLocalRotate(Vector3.up * 180, 2f)
                .SetEase(Ease.Linear)
                .SetLoops(-1, LoopType.Incremental);
        }

        private void OnDestroy()
        {
            transform.DOKill();
        }
    }
}

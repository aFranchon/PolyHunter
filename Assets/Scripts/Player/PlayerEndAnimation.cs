using DG.Tweening;
using UnityEngine;

namespace Player
{
    public class PlayerEndAnimation : MonoBehaviour
    {
        public void OnEndTriggered()
        {
            transform.DORotate(Vector3.forward * 180, .5f)
                .SetLoops(-1, LoopType.Incremental)
                .SetEase(Ease.Linear);
            transform.DOScale(0, 3f)
                .onComplete += () => Destroy(gameObject);
            transform.DOMove(transform.position + Vector3.up * .1f, 3f);
        }

        private void OnDestroy()
        {
            transform.DOKill();
        }
    }
}

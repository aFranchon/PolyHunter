using DG.Tweening;
using UnityEngine;

namespace Anims
{
    public class AnimPopUpScale : MonoBehaviour
    {
        [SerializeField] private Ease ease;
        [SerializeField] private float scaleDuration;
        private void OnEnable()
        {
            transform.DOKill();
            transform.DOScale(Vector3.one, scaleDuration)
                .SetEase(ease)
                .From(Vector3.zero);
        }
    }
}

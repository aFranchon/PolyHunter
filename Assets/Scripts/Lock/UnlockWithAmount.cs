using FSLib.FSGlobalVariables;
using UnityEngine;

namespace Lock
{
    public class UnlockWithAmount : MonoBehaviour
    {
        [SerializeField] private FsGlobalIntSo score;
        [SerializeField] private FsGlobalBoolSo locked;

        [SerializeField] private int maxAmount;

        private void Awake()
        {
            score.OnValueUpdate += OnScoreValueUpdate;
        }

        private void OnScoreValueUpdate()
        {
            if (score.Value >= maxAmount)
                locked.Value = false;
        }
    }
}

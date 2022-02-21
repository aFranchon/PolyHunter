using FSLib.FSGlobalVariables;
using TMPro;
using UnityEngine;

namespace Scoring
{
    public class ScoringDestroyableUi : MonoBehaviour
    {
        [SerializeField] private TMP_Text scoreText;

        [SerializeField] private int scoreToAdd;
        [SerializeField] private FsGlobalIntSo currentScore;

        [SerializeField] private int destroyableId;

        private void Awake()
        {
            CurrenScore = 0;
        }

        private int CurrenScore
        {
            get => currentScore.Value;
            set
            {
                currentScore.Value = value;
                scoreText.text = currentScore.Value.ToString();
            }
        }

        public void OnEnemyDestroyed( /*int Id*/)
        {
            //TODO add check of id
            CurrenScore += scoreToAdd;
        }
    }
}

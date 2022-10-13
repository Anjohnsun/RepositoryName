using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using ScoreSystem;

namespace ScoreSystem {
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI _scoreText;
        private Score _score;

        public void Constructor(Score score)
        {
            _score = score;
            _score.scoreChanged.AddListener(RefreshView);
        }
            
        public void RefreshView()
        {
            _scoreText.text = "SCORE : " + _score.PlayerScore;
        }
    }
}

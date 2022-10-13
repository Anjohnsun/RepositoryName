using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace ScoreSystem
{
    public class Score
    {
        private int _playerScore;

        public int PlayerScore { get => _playerScore; set => _playerScore = value; }

        public Score(int startScore)
        {
            PlayerScore = startScore;
        }

        public UnityEvent scoreChanged = new UnityEvent();

    }
}
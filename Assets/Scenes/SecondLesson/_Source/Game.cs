using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreSystem;

public class Game
{
    private Score _playerScore;
    [SerializeField] private int SCORE;

    public void Constructor(Score score, int startPlayerScore)
    {
        _playerScore = score;
        _playerScore.PlayerScore = SCORE;
        SCORE = startPlayerScore;
    }

    public void StopGame()
    {
        _playerScore.PlayerScore = 0;
        Debug.Log("EXIT EMAE");
    }
    
}

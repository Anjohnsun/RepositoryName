using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreSystem;

public class Game : MonoBehaviour
{
    private Score _playerScore;
    [SerializeField] private int SCORE;

    public void Constructor(Score score)
    {
        _playerScore = score;
        _playerScore.PlayerScore = SCORE;
    }

    private void OnApplicationQuit()
    {
        _playerScore.PlayerScore = 0;
    }

    public void StopGame()
    {
        Debug.Log("EXIT EMAE");
        Application.Quit();
    }
}

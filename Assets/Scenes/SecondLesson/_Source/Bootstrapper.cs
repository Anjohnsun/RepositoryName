using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreSystem;

public class Bootstrapper : MonoBehaviour
{
    [SerializeField] Score _playerScore;
    [SerializeField] Game _game;
    [SerializeField] ClickObject _clickObject;
    [SerializeField] ScoreView _scoreView;
    void Start()
    {
        _playerScore = new Score(0);
        _game.Constructor(_playerScore);
        _scoreView.Constructor(_playerScore);
        _clickObject.Constructor(_playerScore);
    }
}

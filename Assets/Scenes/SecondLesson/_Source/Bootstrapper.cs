using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreSystem;

public class Bootstrapper : MonoBehaviour
{
    [SerializeField] Score _playerScore;
    [SerializeField] Game _game;
    [SerializeField] ClickObject _clickObject;
    [SerializeField] ClickObject _clickObject2;
    [SerializeField] ScoreView _scoreView;
    void Start()
    {
        _playerScore = new Score(0);
        _game = new Game();
        _game.Constructor(_playerScore, 16);
        _scoreView.Constructor(_playerScore);
        _clickObject.Constructor(_playerScore);
        _clickObject2.Constructor(_playerScore);
    }
}

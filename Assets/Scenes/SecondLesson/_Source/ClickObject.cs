using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreSystem;

public class ClickObject : MonoBehaviour
{
    private Score score;
    [SerializeField] private int numberToPlus;

    public void Constructor(Score score)
    {
        this.score = score;
    }

    private void OnMouseDown()
    {
        score.PlayerScore += numberToPlus;
        score.scoreChanged.Invoke();
    }
}

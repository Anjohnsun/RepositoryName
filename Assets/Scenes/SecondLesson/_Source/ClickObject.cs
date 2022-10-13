using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreSystem;

public class ClickObject : MonoBehaviour
{
    private Score score;

    public void Constructor(Score score)
    {
        this.score = score;
        score.scoreChanged.AddListener(Decrement);
    }

    private void OnMouseDown()
    {
        score.scoreChanged.Invoke();
    }

    private void Decrement()
    {
        score.PlayerScore--;
    }
}

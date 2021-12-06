using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        score.score1 += 1;

        if (score.score1 % 10 == 0)
        {
            score.score1 += 1;
        }
        if (score.score1 % 5 == 0)
        {
            score.stageScore += 1;
        }
    }
}

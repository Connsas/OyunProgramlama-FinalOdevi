using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuScore : MonoBehaviour
{
    public TMP_Text scoreText;
    private int score = ScoreSystem.Score;

    void Start()
    {
        scoreText.text = score.ToString();
    }
}

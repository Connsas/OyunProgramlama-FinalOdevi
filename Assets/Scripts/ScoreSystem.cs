using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{

    public static int Score;
    public TMP_Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Score.ToString();
    }
}

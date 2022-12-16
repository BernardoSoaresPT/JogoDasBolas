using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreboardText : MonoBehaviour
{
    Text scoreboardText;

    private void Start()
    {
        scoreboardText = GetComponent<Text>();
    }
    void Update()
    {
        scoreboardText.text = "Score: " + ScoreBoardManager.score;
    }
}

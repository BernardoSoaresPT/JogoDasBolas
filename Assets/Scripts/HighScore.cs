using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    Text scoreboardText;
    private void Start()
    {
        scoreboardText = GetComponent<Text>();
        scoreboardText.text = "HighScore: " + PlayerPrefs.GetInt("HighScore");
    }
}

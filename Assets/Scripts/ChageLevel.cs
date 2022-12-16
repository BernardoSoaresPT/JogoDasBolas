using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChageLevel : MonoBehaviour
{
    float survivalTime = 0;
    [SerializeField] float survivalNeeded;
     Text timerText;
    private void Awake()
    {
        PlayerController.PlayerDeathStart += StopAllCoroutines;
        PlayerController.PlayerDeathEnd += HighScoreScreen;
    }
    private void Start()
    {
        timerText = GetComponentInChildren<Text>();
        survivalTime = survivalNeeded;
        timerText.text = "TIMER :" + survivalTime;
        StartCoroutine(SceneTimer());
    }
    private void OnDestroy()
    {
        PlayerController.PlayerDeathStart -= StopAllCoroutines;
        PlayerController.PlayerDeathEnd -= HighScoreScreen;
    }
    IEnumerator SceneTimer()
    {
        while (survivalTime > 0)
        {
            yield return new WaitForSeconds(1.0f);
            survivalTime--;
            timerText.text = "TIMER :" + survivalTime;
        }
        if (SceneManager.GetActiveScene().buildIndex ==2)
        {
            HighScoreScreen();
        }
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    private void HighScoreScreen()
    {
        if (ScoreBoardManager.score>PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", ScoreBoardManager.score);
        }
        SceneManager.LoadScene(3);
    }
}

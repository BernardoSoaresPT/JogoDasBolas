using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadScene(1);
    }
    public void ResetGame()
    {
        ScoreBoardManager.ResetScore();
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoardManager : MonoBehaviour
{
    public static int score = 0;
    public static void IncreaseScore()
    {
        score++;
    }
    public static void ResetScore()
    {
        score = 0;
    }
}

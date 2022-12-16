using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAreas : MonoBehaviour
{
   public static Vector2 SpawnArea()
    {
        Vector2 spawnPos;
        switch (Random.Range(1, 5))
        {
            case 1:
                spawnPos = new Vector2(Random.Range(-8.0f, -3.0f), Random.Range(0.0f, 4.0f));
                break;
            case 2:
                spawnPos = new Vector2(Random.Range(3.0f, 8.0f), Random.Range(0.0f, 4.0f));
                break;
            case 3:
                spawnPos = new Vector2(Random.Range(3.0f, 8.0f), Random.Range(-5.0f, -3.0f));
                break;
            case 4:
               spawnPos = new Vector2(Random.Range(-8.0f, -3.0f), Random.Range(-5.0f, -3.0f));
                break;
            default:
                spawnPos = Vector2.zero;
                break;
        }
        return spawnPos;
    }
}

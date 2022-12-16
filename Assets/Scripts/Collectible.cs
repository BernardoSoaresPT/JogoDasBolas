using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collectible : Bounce
{
    [SerializeField] GameObject enememyTracking;
    [SerializeField] GameObject enemyBounce;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.transform.position = SpawnAreas.SpawnArea();
            Vector2 movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            rb.AddForce(movement * speed);
            SpawnEnemy();
            ScoreBoardManager.IncreaseScore();
        }
    }
    private void SpawnEnemy()
    {
        GameObject tempGameObj;
        if (Random.value < 0.5f)
        {
            tempGameObj = Instantiate(enememyTracking);
        }
        else
        {
            tempGameObj = Instantiate(enemyBounce);
        }
        tempGameObj.transform.position = SpawnAreas.SpawnArea();
    }
}

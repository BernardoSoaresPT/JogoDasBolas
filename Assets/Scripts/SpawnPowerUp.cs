using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowerUp : MonoBehaviour
{
    [SerializeField] GameObject powerUpPrefab;
    bool powerUpIsSpawning = false;
    [SerializeField] float powerUpSpawnAfterSeconds;
    private void Start()
    {
        PoweUp.PowerUp += PowerUpPicked;
    }
    private void OnDestroy()
    {
        PoweUp.PowerUp -= PowerUpPicked;
    }
    private void PowerUpPicked()
    {
        powerUpIsSpawning = false;
    }
    private void Update()
    {
        if (!powerUpIsSpawning)
        {
            StartCoroutine(PowerUpSpawnTimer());
        }
    }
    IEnumerator PowerUpSpawnTimer()
    {
        powerUpIsSpawning = true;
        float spawnTimer = 0f;
        while (spawnTimer < powerUpSpawnAfterSeconds)
        {
            yield return new WaitForSeconds(1.0f);
            spawnTimer++;
        }
        PowerUpSpawn();
    }
    private void PowerUpSpawn()
    {
        powerUpPrefab.transform.position = SpawnAreas.SpawnArea();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoweUp : MonoBehaviour
{
    [SerializeField] float maxpowerupTimer;
    public delegate void PowerPack();
    public static event PowerPack PowerUp;
    public static event PowerPack StopPowerUp;
    IEnumerator PowerUpTimer()
    {
        float powerTimer = 0;
        while (powerTimer < maxpowerupTimer)
        {
            yield return new WaitForSeconds(1.0f);
            powerTimer++;
        }
        StopPowerUp();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.transform.position = Vector3.down * 30f;
            if (PowerUp != null)
            {
                StartCoroutine(PowerUpTimer());
                PowerUp();
            }
        }
    }
}

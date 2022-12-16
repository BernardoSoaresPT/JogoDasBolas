using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTracking : StandardEnemy
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            var target = GameObject.FindWithTag("Player").transform;
            rb.velocity = new Vector2(target.position.x - rb.position.x,
                                      target.position.y - rb.position.y);
        }
    }
}

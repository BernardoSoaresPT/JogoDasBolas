using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    protected Rigidbody2D rb;
    public int speed;
    protected void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)); ;
        rb.AddForce(movement * speed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    #region Variables
    private Rigidbody2D rb;
    public float speed;
    private float horizontal;
    private float vertical;
    public delegate void Death();
    public static event Death PlayerDeathStart;
    public static event Death PlayerDeathEnd;
    private Animator anim;
    bool dead = false;
    #endregion
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (dead)
        {
            return;
        }
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        anim.SetFloat("Speed", horizontal + vertical);
    }
    private void FixedUpdate()
    {
        Vector2 pos = transform.position;
        pos.x += horizontal * speed * Time.deltaTime;
        pos.y += vertical * speed * Time.deltaTime;
        rb.MovePosition(pos);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (dead)
        {
            return;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            PlayerDeathStart();
            dead = true;
            rb.velocity = Vector2.zero;
            anim.SetTrigger("Death");
        }
    }
    public void DeathAnimationEvent()
    {
        PlayerDeathEnd();
    }
}

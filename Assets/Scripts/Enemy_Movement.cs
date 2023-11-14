using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed;

    bool flip;
    // Start is called before the first frame update
    void Start()
    {
        flip = true;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (flip)
        {
            rb.velocity = new Vector2(rb.velocity.x, speed);
        }
        if (!flip)
        {
            rb.velocity = new Vector2(rb.velocity.x, -speed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BatasEnemy1"))
        {
            flip = !flip;
        }
        if (collision.gameObject.CompareTag("BatasEnemy2"))
        {
            flip = true;
        }
    }
}


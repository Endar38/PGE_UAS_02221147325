using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    public SpriteRenderer sprite;

    public Rigidbody2D rb;

    public float tekanan = 400f;

    private bool isJumping;
    public Animator anim;

    public int maxJump = 2;
    private int jumpLeft;
 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpLeft = maxJump;
    }

    // Update is called once per frame
    void Update()
    {

        if (!isJumping && rb.velocity.y <= 0)
        {
            jumpLeft = maxJump;
        }
        if(Input.GetKeyDown(KeyCode.RightArrow) && jumpLeft > 0)
        {
            float Haxis = Input.GetAxisRaw("Horizontal");
            Vector2 move = new Vector2(Haxis * Time.deltaTime, 100);
            anim.SetBool("jump", true);
            //transform.Translate(move * 0.01f);
            rb.AddForce(new Vector2(100, tekanan/1.5f));
            if(Haxis < 0)
            {
                sprite.flipX = true;
            }else if(Haxis > 0)
            {
                 sprite.flipX = false;
            }
            isJumping = true;

            jumpLeft --;

            
 
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && jumpLeft > 0)
        {
            float Haxis = Input.GetAxisRaw("Horizontal");
            Vector2 move = new Vector2(Haxis * Time.deltaTime, 100);
            //transform.Translate(move * 0.01f);
            rb.AddForce(new Vector2(-100, tekanan/1.5f));
            if (Haxis < 0)
            {
                sprite.flipX = true;
            }
            else if (Haxis > 0)
            {
                sprite.flipX = false;
            }
            isJumping = true;
            jumpLeft--;
        }



        

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {




            anim.SetBool("Makan", false);
            anim.SetBool("Idle", false);
            anim.ResetTrigger("Lompat");
            isJumping = false;
            anim.SetBool("jump", false);
        }
    }
}

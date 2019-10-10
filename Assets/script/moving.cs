using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
//    public touch_pad TouchPad;
    public button button;
    Rigidbody2D rb;
    Vector3 position;

    private bool filumR = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        // Vector2 direction = TouchPad.GetDirection();
        int moving = button.GetMoving();
        rb.velocity = new Vector2(moving*2.16f, rb.velocity.y);

        if (moving > 0 && !filumR)
        {
            filumR = false;
            flip();
        }
        else if (moving < 0 && filumR)
        {
            filumR = true;
            flip();
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "type_default")
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(transform.up * 8, ForceMode2D.Impulse);
            Destroy(other.gameObject, 1);
        }
        else if (other.gameObject.tag == "type_start")
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(transform.up * 20, ForceMode2D.Impulse);
        }
    }

    void flip()
    {
        filumR = !filumR;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}
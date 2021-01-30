using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    public float movespeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    // Update is called once per frame

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (transform.position.x <= -9f)
        {
            transform.position = new Vector2(-9f, transform.position.y);
        }
        else if (transform.position.x >= 9f)
        {
            transform.position = new Vector2(9f, transform.position.y);
        }

        // Y axis
        if (transform.position.y <= -4.5f)
        {
            transform.position = new Vector2(transform.position.x, -4.5f);
        }
        else if (transform.position.y >= 4.5f)
        {
            transform.position = new Vector2(transform.position.x, 4.5f);
        }
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movespeed * Time.deltaTime);
    }
}
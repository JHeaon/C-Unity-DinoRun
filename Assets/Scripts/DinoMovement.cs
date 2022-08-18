using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float jumpvalue = 7f;
    int jumpstack = 0;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        jump();
    }

    void jump()
    {

        if (Input.GetKeyDown(KeyCode.Space) && jumpstack <= 1)
        {
            jumpstack += 1;
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumpvalue;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        jumpstack = 0;
    }
}

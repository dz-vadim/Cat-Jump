using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * 8f, ForceMode2D.Impulse);
        }
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * 8f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * 8f);
        }
    }
}

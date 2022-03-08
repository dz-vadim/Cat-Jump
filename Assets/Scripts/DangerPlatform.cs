using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerPlatform : MonoBehaviour
{
    Transform cam;
    public float jumpForce = 10f;
    void Start()
    {
        cam = GameObject.Find("Main Camera").transform;
    }
    void Update()
    {
        float diff = cam.position.y - transform.position.y;
        if (diff > 6f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D playerRb = collision.gameObject.GetComponent<Rigidbody2D>();

            if (playerRb != null)
            {
                playerRb.velocity = Vector2.up * jumpForce;
                Destroy(gameObject);
            }
        }
    }
}

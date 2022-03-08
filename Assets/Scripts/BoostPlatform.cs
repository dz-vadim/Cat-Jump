using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostPlatform : MonoBehaviour
{
    Transform camera;
    public float jumpForce = 30f;
    void Start()
    {
        camera = GameObject.Find("Main Camera").transform;
    }
    void Update()
    {
        float diff = camera.position.y - transform.position.y;
        if (diff > 6f)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0)
        {
            Rigidbody2D playerRb = collision.gameObject.GetComponent<Rigidbody2D>();
            if (playerRb != null)
            {
                playerRb.velocity = Vector2.up * jumpForce;
            }
        }
    }
}

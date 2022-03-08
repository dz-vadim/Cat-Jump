using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpForce = 10f;
    public float shiftDistance = 10.5f;
    private Camera _mainCamera;
    private void Start()
    {
        _mainCamera = FindObjectOfType<Camera>();
        //Destroy(gameObject, 10f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D playerRb =
                collision.gameObject.GetComponent<Rigidbody2D>();

            if (playerRb != null)
            {
                playerRb.velocity = Vector2.up * jumpForce;
                Player.isJumped = true;
            }
        }
        else
        {
            Player.isJumped = false;
        }
    }

    void Update()
    {
        /*Vector3 transformPosition = transform.position;
        Debug.Log(gameObject.name);
            Debug.Log(transformPosition.y - _mainCamera.transform.position.y);
        if ((transformPosition.y - _mainCamera.transform.position.y) > 20f)
        {
            
            Destroy(gameObject);
        }
        transform.position = transformPosition;*/
    }
}

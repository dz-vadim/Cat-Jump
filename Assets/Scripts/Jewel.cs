using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jewel : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player.coins++;
            Destroy(gameObject);
        }
    }
}

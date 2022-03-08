using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp : MonoBehaviour
{
    void Start()
    {
        for (int i = -100; i <= 100 ; i++)
        {
            if (i % 5 == 0)
            Debug.Log(i);
        }
        Debug.Log("Удаление через 4 с");
        Destroy(gameObject, 4f);
    }

    void Update()
    {
        
    }
}

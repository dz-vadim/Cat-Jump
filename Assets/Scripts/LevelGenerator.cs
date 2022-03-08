using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject plat;
    public GameObject boostPlat;
    public GameObject dangerPlat;
    Vector3 pos = new Vector3();
    void Start()
    {

        for (int i = 0; i < 100; i++)
        {
            RegenerationLevel();
        }
    }

    float minDis = 0.7f;
    float maxDis = 2f;
    void Spawn(GameObject obj)
    {
        pos.y = pos.y + Random.Range(minDis, maxDis);
        pos.x = Random.Range(-2f, 2f);
        Instantiate(obj, pos, Quaternion.identity);
    }

    public void RegenerationLevel()
    {
        int destiny = Random.Range(1, 101);

        if (destiny > 80)
        {
            Spawn(boostPlat);
        }
        else
        {
            if (destiny > 90)
            {
                Spawn(dangerPlat);
            }
            else
            {
                Spawn(plat);
            }
        }
        if (maxDis < 3.5f) maxDis += 0.01f;
        if (minDis < 3.4f) minDis += 0.01f;
    }
}

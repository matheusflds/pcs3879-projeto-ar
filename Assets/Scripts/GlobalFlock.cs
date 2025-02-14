﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalFlock : MonoBehaviour
{
    public GameObject fishPrefab;
    public GameObject goalPrefab;
    public static float tankSize = 0.5f;

    static int numFish = 4;
    public static GameObject[] allFish = new GameObject[numFish];

    public static Vector3 goalPos = Vector3.zero;

    public GameObject imageTarget;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numFish; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-tankSize, tankSize),
                                      0,
                                      Random.Range(-tankSize, tankSize));
            allFish[i] = (GameObject)Instantiate(fishPrefab, pos, Quaternion.identity);
            allFish[i].transform.parent = this.transform;
            allFish[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0, 10000) < 50)
        {
            goalPos = new Vector3(Random.Range(-tankSize, tankSize),
                                  0,
                                  Random.Range(-tankSize, tankSize));
            goalPrefab.transform.localPosition = goalPos;
            goalPos = goalPrefab.transform.position;
        }
    }
}

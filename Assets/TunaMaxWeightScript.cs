﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TunaMaxWeightScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool fishImage = TunaCatalogScript.fishImage;
        string weight = TunaCatalogScript.maxWeight;

        TextMeshProUGUI fishMaxWeightComponent = GetComponent<TextMeshProUGUI>();

        if (fishImage == true)
        {
            fishMaxWeightComponent.text = weight;
        }
    }
}

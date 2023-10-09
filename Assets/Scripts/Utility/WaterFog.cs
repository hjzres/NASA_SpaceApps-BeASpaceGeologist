using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFog : MonoBehaviour
{
    private Transform water;

    private void Start()
    {
        water = GameObject.Find("Sea").transform;
        RenderSettings.fog = false;
    }

    private void Update()
    {
        if (transform.position.y - 1f < water.position.y)
        {
            RenderSettings.fog = true;
        }

        else
        {
            RenderSettings.fog = false;
        }
    }
}

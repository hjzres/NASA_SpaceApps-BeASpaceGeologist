using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhichMaterial : MonoBehaviour
{
    public GameObject rockType;
    public GameObject[] rockTypes = new GameObject[4];

    public int randomRockType = 0;
    public int randomOre = 0;

    public Material oreColour;

    private void Update()
    {
        
    }

    private void spawner()
    {
        randomRockType = (int)Random.Range(0, rockTypes.Length);

        rockType = rockTypes[randomRockType];
        randomOre = (int)Random.Range(0, 3);

        switch (StaticData.currentScene)
        {
            case 1:
                switch(randomOre)
                {
                    case 0:
                        oreColour.color = Color.HSVToRGB(90f, 6f, 85f);
                        break;
                    case 1:
                        oreColour.color = Color.HSVToRGB(40f, 88f, 93f);
                        break;
                    case 2:
                        oreColour.color = Color.HSVToRGB(0f, 44f, 58f);
                        break;
                }
                break;
            case 2:
                randomOre = (int)Random.Range(0, StaticData.worldTwoRocks.Count);
                break;
            case 3:
                randomOre = (int)Random.Range(0, StaticData.worldThreeRocks.Count);
                break;
        }



        Instantiate(rockType, transform.position, transform.rotation);


    }

}

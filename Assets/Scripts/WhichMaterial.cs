using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhichMaterial : MonoBehaviour
{
    public GameObject rockType;
    public GameObject[] rockTypes = new GameObject[3];

    public Renderer renderer;

    public int randomOre = 0;

    public Material originalMaterial;
    

    private void Update()
    {
        List<Transform> children = new();

        foreach (Transform child in transform)
        {
            Debug.Log(child.name);
            children.Add(child);
        }

        if(children.Count == 0)
        {
            spawner();
        }
    }

    private void spawner()
    {

        Material oreMaterial = new Material(originalMaterial);
        randomOre = (int)Random.Range(0, 3);

        rockType = rockTypes[StaticData.currentScene-1];

        

        switch (StaticData.currentScene)
        {
            case 3:
                switch(randomOre)
                {
                    case 0:
                        oreMaterial.color = Color.HSVToRGB(90f, 6f, 85f);
                        break;
                    case 1:
                        oreMaterial.color = Color.HSVToRGB(40f, 88f, 93f);
                        break;
                    case 2:
                        oreMaterial.color = Color.HSVToRGB(0f, 44f, 58f);
                        break;
                }
                renderer = rockType.GetComponent<Renderer>();
                renderer.material = oreMaterial;
                break;
            case 2:
                
                switch (randomOre)
                {
                    case 0:
                        oreMaterial.color = Color.HSVToRGB(50f, 100f, 100f);
                        break;
                    case 1:
                        oreMaterial.color = Color.HSVToRGB(0f, 0f, 73f);
                        break;
                    case 2:
                        oreMaterial.color = Color.HSVToRGB(0f, 4f, 18f);
                        break;
                }
                List<Transform> shards2 = new();
                foreach (Transform child in transform)
                {
                    Debug.Log(child.name);
                    shards2.Add(child);
                    renderer = child.GetComponent<Renderer>();
                    renderer.material = oreMaterial;
                }
                break;
            case 1:
                switch (randomOre)
                {
                    case 0:
                        oreMaterial.color = Color.HSVToRGB(318f, 22f, 22f);
                        break;
                    case 1:
                        oreMaterial.color = Color.HSVToRGB(195f, 14f, 21f);
                        break;
                    case 2:
                        oreMaterial.color = Color.HSVToRGB(58f, 42f, 34f);
                        break;
                }
                List<Transform> shardsHolder = new();

                foreach (Transform child in transform)
                {
                    Debug.Log(child.name);
                    shardsHolder.Add(child);
                    List<Transform> shard3 = new();

                    foreach (Transform shard in transform)
                    {
                        Debug.Log(shard.name);
                        shard3.Add(shard);
                        renderer = shard.GetComponent<Renderer>();
                        renderer.material = oreMaterial;
                    }

                }

                break;
        }
        Instantiate(rockType, transform.position, transform.rotation, transform);

    }

}

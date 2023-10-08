using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mineable : MonoBehaviour
{
    public float health = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(health <= 0) {
            Destroy(gameObject);
        }
    }

    public void Mine(float damage) {
        health -= damage;
        Debug.Log(health);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drill : Tool {
    // Damage done per second
    public float speed = 1f;
    public ParticleSystem particles;
    
    private ParticleSystem.EmissionModule em;

    void Start() {
        em = particles.emission;
    }

    public override void LeftClickHeld(Interact interact) {

        RaycastHit hit;
        if(interact.Raycast(out hit)) {
            if(hit.transform.gameObject.CompareTag("mineable")) {
                Debug.Log(hit.normal);
                particles.transform.position = hit.point;
                particles.transform.rotation = Quaternion.LookRotation(hit.normal);
                em.enabled = true;
                hit.transform.gameObject.GetComponent<Mineable>().Mine(speed * Time.deltaTime);
            }
        } else {
            em.enabled = false;
        }
    }

    public override void LeftClickUp(Interact interact) {
        em.enabled = false;
    }
}

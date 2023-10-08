using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drill : Tool {
    // Damage done per second
    public float speed = 1f;
    public GameObject drillEffectsPrefab;

    private GameObject drillEffects;
    private ParticleSystem particles;
    private AudioSource crushAudio;
    private AudioSource drillAudio;
    

    private GameManager gameManager;
    private ParticleSystem.EmissionModule em;

    void Start() {
        drillEffects = Instantiate(drillEffectsPrefab);
        gameManager = GameObject.FindObjectOfType<GameManager>();
        particles = drillEffects.GetComponent<ParticleSystem>();

        AudioSource[] allAudio = drillEffects.GetComponents<AudioSource>();
        crushAudio = allAudio[0];
        drillAudio = allAudio[1];

        em = particles.emission;
    }

    public override void LeftClickHeld(Interact interact) {

        RaycastHit hit;
        if(interact.Raycast(out hit) && gameManager.robot.gameObject.activeInHierarchy) {
            if(hit.transform.gameObject.CompareTag("mineable")) {

                particles.transform.position = hit.point;
                particles.transform.rotation = Quaternion.LookRotation(hit.normal);

                em.enabled = true;
                if(!crushAudio.isPlaying){
                    crushAudio.Play();
                }
                
                hit.transform.gameObject.GetComponent<Mineable>().Mine(speed * Time.deltaTime);
            }
        } else {
            em.enabled = false;
            crushAudio.Stop();
        }
    }

    public override void LeftClick(Interact interact) {
        drillAudio.Play();
    }

    public override void LeftClickUp(Interact interact) {
        em.enabled = false;
        crushAudio.Stop();

        drillAudio.Stop();
    }
}

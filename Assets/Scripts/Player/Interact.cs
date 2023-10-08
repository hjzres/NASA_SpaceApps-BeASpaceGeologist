using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public float maxDistance = 3;
    public float interactInterval = 0.1f;

    [SerializeField]
    public Tool tool;

    private Camera cam;
    private float lastInteract = 0;

    private void Start()
    {
        cam = GetComponent<Camera>();

        tool = new DebugStick();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            Vector3 rayOrigin = cam.ViewportToWorldPoint (new Vector3(0.5f, 0.5f, 0.0f));

            RaycastHit hit;

            if(Physics.Raycast(rayOrigin, transform.forward, out hit, maxDistance)) {
                if((Time.time - lastInteract) < interactInterval) {
                    return;
                }

                lastInteract = Time.time;

                tool.LeftClick(hit);
                
            }
        }
    }
}

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


    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)) {
            tool.LeftClickHeld(this);
        }

        if(Input.GetMouseButtonDown(0)) {
            tool.LeftClick(this);
        }

        if(Input.GetMouseButtonUp(0)) {
            tool.LeftClickUp(this);
        }
    }

    public bool Raycast(out RaycastHit hit) {
        Vector3 rayOrigin = cam.ViewportToWorldPoint (new Vector3(0.5f, 0.5f, 0.0f));
        return Physics.Raycast(rayOrigin, cam.transform.forward, out hit, maxDistance);
    }
}

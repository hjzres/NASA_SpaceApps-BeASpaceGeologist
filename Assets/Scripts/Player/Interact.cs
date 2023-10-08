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

    private void Start()
    {
        cam = GetComponentInChildren<Camera>();
    }

    private void Update()
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

        if(Input.GetMouseButtonDown(1)) {
            tool.RightClick(this);
        }
    }

    public bool Raycast(out RaycastHit hit) {
        Vector3 rayOrigin = cam.ViewportToWorldPoint (new Vector3(0.5f, 0.5f, 0.0f));
        return Physics.Raycast(rayOrigin, cam.transform.forward, out hit, maxDistance);
    }
}

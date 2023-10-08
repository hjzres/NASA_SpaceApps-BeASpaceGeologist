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
    }

    private void Update()
    {
        
    }
}

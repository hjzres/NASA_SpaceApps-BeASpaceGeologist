using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPerspectives : Tool
{
    private Camera player;

    private Camera robot;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<Camera>();
        robot = GameObject.FindGameObjectWithTag("Robot").GetComponentInChildren<Camera>();
    }

    public override void LeftClick(Interact interact)
    {
    }
}

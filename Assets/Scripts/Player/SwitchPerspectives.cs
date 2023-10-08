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
        RaycastHit hit;

        if (interact.Raycast(out hit))
        {
            if (hit.collider.CompareTag("Robot") && player.gameObject.activeInHierarchy)
            {
                player.gameObject.SetActive(false);
                robot.gameObject.SetActive(true);
                player.transform.parent.GetComponent<PlayerMovement>().enabled = false;
                robot.transform.parent.GetComponent<RobotMovement>().enabled = true;
            }

            if (hit.collider.CompareTag("Player") && robot.gameObject.activeInHierarchy)
            {
                robot.gameObject.SetActive(false);
                player.gameObject.SetActive(true);
                robot.transform.parent.GetComponent<RobotMovement>().enabled = false;
                player.transform.parent.GetComponent<PlayerMovement>().enabled = true;
            }
        }
    }
}

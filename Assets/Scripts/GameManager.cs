using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Camera player;

    public Camera robot;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        player = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<Camera>();
        robot = GameObject.FindGameObjectWithTag("Robot").GetComponentInChildren<Camera>();

        robot.gameObject.SetActive(false);
        robot.transform.parent.GetComponent<RobotMovement>().enabled = false;
    }
}

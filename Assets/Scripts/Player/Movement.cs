using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public enum MoveState
    {
        Walking,
        Sprinting
    }

    [Header("Properties")]
    public Vector2 mouseSensitivity;

    public static MoveState moveState;

    public static int state
    {
        get { return (int)moveState; }
        set { }
    }

    public int speed
    {
        get { return state; }
        set
        {
            switch (state)
            {
                case (int)MoveState.Walking:
                    speed = 2;
                    break;
                
                case (int)MoveState.Sprinting:
                    speed = 5;
                    break;
            }
        }
    }

    float xRotation, yRotation;

    Transform cam;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        cam = FindObjectOfType<Camera>().transform;
    }

    private void Update()
    {
        moveState = Sprinting() ? MoveState.Sprinting : MoveState.Walking;
        CameraMovement();
    }

    void CameraMovement()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.fixedDeltaTime * mouseSensitivity.x;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.fixedDeltaTime * mouseSensitivity.y;

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        cam.rotation = Quaternion.Euler(xRotation, yRotation, 0f);
        transform.rotation = Quaternion.Euler(0f, yRotation, 0f);
    }

    private bool Sprinting()
    {
        return Input.GetKey(KeyCode.LeftShift);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMovement : MonoBehaviour
{
    [Header("Properties")]
    public const int speed = 3;

    Rigidbody rigidBody;
    Camera cam;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        rigidBody = GetComponent<Rigidbody>();
        cam = GetComponentInChildren<Camera>();
    }

    private void Update()
    {
        CameraMovement();
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 moveDirection = -transform.forward * verticalInput;
        rigidBody.drag = 5f;

        rigidBody.AddForce(moveDirection * speed * 10, ForceMode.Force);

        transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y + (horizontalInput * speed), 0f);
    }

    void CameraMovement()
    {
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.fixedDeltaTime * StaticData.mouseSensitivity.y;

        float newRot = cam.transform.rotation.eulerAngles.x - mouseY;
        if(newRot > 180) {
            newRot -= 360;
        }
        newRot = Mathf.Clamp(newRot, -30, 30);

        cam.transform.rotation = Quaternion.Euler(
            newRot,
            cam.transform.rotation.eulerAngles.y,
            cam.transform.rotation.eulerAngles.z
        );
    }
}

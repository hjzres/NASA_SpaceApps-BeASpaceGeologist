using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMovement : MonoBehaviour
{
    [Header("Properties")]
    public const int speed = 3;

    private Vector3 moveDirection;

    float horizontalInput, verticalInput;

<<<<<<< Updated upstream
    private void Start()
    {
        
=======
    GameManager gameManager;
    Rigidbody rigidBody;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        gameManager = FindObjectOfType<GameManager>();
        rigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        CameraMovement();
    }

    private void FixedUpdate()
    {
        moveDirection = transform.forward * verticalInput;
        rigidBody.drag = 5f;

        rigidBody.AddForce(moveDirection * speed * 10, ForceMode.Force);

        transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y + (horizontalInput * speed), 0f);
    }

    void CameraMovement()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.fixedDeltaTime * StaticData.mouseSensitivity.x;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.fixedDeltaTime * StaticData.mouseSensitivity.y;

        StaticData.yRotation += mouseX;
        StaticData.xRotation -= mouseY;

        StaticData.yRotation = Mathf.Clamp(StaticData.yRotation, -50f, 50f);

        gameManager.robot.transform.rotation = Quaternion.Euler(StaticData.xRotation, transform.rotation.eulerAngles.y + StaticData.yRotation, 0f);
>>>>>>> Stashed changes
    }
}

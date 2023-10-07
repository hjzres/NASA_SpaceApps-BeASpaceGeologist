using System.Linq;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public enum MoveState
    {
        Walking,
        Sprinting
    }

    public PhysicMaterial slipPhysics;

    [Header("Properties")]

    public static MoveState moveState;

    public int speed; 
    
    [Range(0, 10)] public int jumpForce;

    public bool readyToJump;

    private Vector3 moveDirection;

    float horizontalInput, verticalInput;

    Transform cam;
    Collider playerObject;
    Rigidbody rigidBody;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        cam = GameObject.Find("Player Cam").transform;
        playerObject = GetComponentInChildren<Collider>();
        rigidBody = GetComponent<Rigidbody>();

        rigidBody.freezeRotation = true;
        readyToJump = true;
    }

    private void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        moveState = Sprinting() ? MoveState.Sprinting : MoveState.Walking;  

        Vector3 flatVelocity = new Vector3(rigidBody.velocity.x, 0f, rigidBody.velocity.z);
        if (flatVelocity.magnitude > speed)
        {
            Vector3 limitedVel = flatVelocity.normalized * speed;
            rigidBody.velocity = new Vector3
                (
                    limitedVel.x, 
                    rigidBody.velocity.y, 
                    limitedVel.z
                );
        }

        Jump();
        CameraMovement();
    }

    private void FixedUpdate()
    {
        speed = moveState switch
        {
            MoveState.Walking => 2,
            MoveState.Sprinting => 4,
            _ => 2
        };

        moveDirection = transform.forward * verticalInput + transform.right * horizontalInput;
        rigidBody.drag = Grounded() ? 5f : 0;
        playerObject.material = horizontalInput != 0 || verticalInput != 0 || !Grounded() ? slipPhysics : null;

        rigidBody.AddForce(moveDirection * speed * 10, ForceMode.Force);
    }

    void Jump()
    {
        if (Input.GetKey(KeyCode.Space) && Grounded() && readyToJump)
        {
            readyToJump = false;
            rigidBody.velocity = new Vector3(rigidBody.velocity.x, 0f, rigidBody.velocity.z);  
            rigidBody.AddForce(transform.up * jumpForce * 2f, ForceMode.Impulse);
            Invoke(nameof(ResetJump), 1f);
        }
    }

    void CameraMovement()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.fixedDeltaTime * StaticData.mouseSensitivity.x;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.fixedDeltaTime * StaticData.mouseSensitivity.y;

        StaticData.yRotation += mouseX;
        StaticData.xRotation -= mouseY;
        StaticData.xRotation = Mathf.Clamp(StaticData.xRotation, -90f, 90f);

        cam.rotation = Quaternion.Euler(StaticData.xRotation, StaticData.yRotation, 0f);
        transform.rotation = Quaternion.Euler(0f, StaticData.yRotation, 0f);
    }

    private bool Sprinting() => Input.GetKey(KeyCode.LeftShift) && (verticalInput > 0 || horizontalInput != 0);

    private bool Grounded() => Physics.Raycast(transform.position, Vector3.down, playerObject.transform.localScale.y+ .2f);

    private void ResetJump() => readyToJump = true;
}

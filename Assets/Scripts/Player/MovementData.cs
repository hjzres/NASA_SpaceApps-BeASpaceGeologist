using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public static float horizontalInput, verticalInput;

    public static float mouseX, mouseY;

    private void Update()
    {
        mouseX = Input.GetAxisRaw("Mouse X") * Time.fixedDeltaTime * StaticData.mouseSensitivity.x;
        mouseY = Input.GetAxisRaw("Mouse Y") * Time.fixedDeltaTime * StaticData.mouseSensitivity.y;
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    public static void CameraMovement(Transform camera, Transform obj, bool robot = false)
    {

    }
}

using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 50f;

    void Update()
    {
        float verticalInput = 0f;
        float horizontalInput = 0f;

        if (Keyboard.current.upArrowKey.isPressed)
            verticalInput = 1f;

        if (Keyboard.current.downArrowKey.isPressed)
            verticalInput = -1f;

        if (Keyboard.current.leftArrowKey.isPressed)
            horizontalInput = -1f;

        if (Keyboard.current.rightArrowKey.isPressed)
            horizontalInput = 1f;

        transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);
    }
}
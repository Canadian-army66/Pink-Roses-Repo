using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class movement : MonoBehaviour
{
    public float sensX;
    public float sensY;
    private Vector2 lookAround;
    public bool isKicking;
    public PlayerInput input;

    public Transform orientation;

    float xRotation;
    float yRotation;

    private void Start()
    {
        Cursor.visible = false;

        if(input.currentControlScheme == "Keyboard&Mouse")
        {
            sensX = 20;
            sensY = 20;
        }
        else
        {
            sensX = 200;
            sensY = 200;
        }
    }
    private void Update()
    {
        float mouseX = lookAround.x * Time.deltaTime * sensX;
        float mouseY = lookAround.y * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;
         xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);

        if (input.currentControlScheme == "Keyboard&Mouse" && sensX != 20 && sensY != 20)
        {
            sensX = 20;
            sensY = 20;
        }
        else if (input.currentControlScheme == "Gamepad" && sensX != 200 && sensY != 200)
        {
            sensX = 200;
            sensY = 200;
        }
    }

    public void OnLook(InputValue lookValue)
    {
        lookAround = lookValue.Get<Vector2>();
    }

    public void OnKick(InputValue value)
    {
        isKicking = value.isPressed;
    }
}

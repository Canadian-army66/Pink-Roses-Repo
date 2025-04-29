using UnityEngine;
using UnityEngine.InputSystem;

public class InputDeviceSwitcher : MonoBehaviour
{
    public GameObject pressSpaceObject;
    public GameObject pressAObject;

    private void OnEnable()
    {
        InputSystem.onDeviceChange += OnInputDeviceChange;
        CheckForGamepad(); // Initial check in case a gamepad is already connected
    }

    private void OnDisable()
    {
        InputSystem.onDeviceChange -= OnInputDeviceChange;
    }

    private void OnInputDeviceChange(InputDevice device, InputDeviceChange change)
    {
        switch (change)
        {
            case InputDeviceChange.Added:
                CheckForGamepad();
                break;
            case InputDeviceChange.Removed:
                CheckForGamepad();
                break;
                // You might want to handle other cases like Reconnected if needed
        }
    }

    private void CheckForGamepad()
    {
        bool gamepadConnected = Gamepad.all.Count > 0;

        if (pressSpaceObject != null)
        {
            pressSpaceObject.SetActive(!gamepadConnected);
        }

        if (pressAObject != null)
        {
            pressAObject.SetActive(gamepadConnected);
        }
    }
}

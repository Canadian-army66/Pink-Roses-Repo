using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerInput : MonoBehaviour
{
    public bool pluggedIn;
    public GameObject Player;

    void Start()
    {
        if (pluggedIn == false)
        {
            this.enabled = false;
        }
        else
        {
            this.enabled = true;
        }
    }

    void Update()
    {
        
    }

    void Plugged()
    {
        Gamepad gamepad = GetComponent<Gamepad>();
        if (gamepad == null )
        {
            Debug.Log("No Controller Connected!");
            pluggedIn = false;
        }
        else
        {
            Debug.Log("Controller Found!");
            pluggedIn = false;
        }
    }
}

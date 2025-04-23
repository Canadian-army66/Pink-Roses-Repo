using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerInput : MonoBehaviour
{
    public bool pluggedIn;
    public GameObject Player;
    public PlayerInput controllerInput;

    void Start()
    {
        controllerInput = GetComponent<PlayerInput>();
    }

    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class Navigator : MonoBehaviour
{
    public Button toGame;
    void Start()
    {
        EventSystem.current.SetSelectedGameObject(toGame.gameObject);
    }
}

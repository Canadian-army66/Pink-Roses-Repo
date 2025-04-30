using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class StartCode : MonoBehaviour
{
    public GameObject bob;
    public float moveOffScreenSpeed = 5f;
    public float destroyDelay = 3f;
    public StartCode startCode;

    private Vector3 offScreenDirection = Vector2.up;

    void Start()
    {
            Destroy(bob.gameObject, destroyDelay);
    }
    void Update()
    {
        bob.transform.position += offScreenDirection * moveOffScreenSpeed * Time.deltaTime;
    }
}
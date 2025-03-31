using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public bool theyGone;
    void Start()
    {
        var go = new GameObject { name = "StateManager" };
        DontDestroyOnLoad(go);
    }

    void Update()
    {
       
    }
}
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public bool theyGone = false;
    private int enemiesInScene;
    void Start()
    {
        var go = new GameObject { name = "StateManager" };
        DontDestroyOnLoad(go);
        enemiesInScene = GameObject.FindGameObjectsWithTag("Enemy").Length;
        
    }

    void Update()
    {
        if (enemiesInScene == 0)
        {
            theyGone = true;
            GameObject.FindWithTag("spawnManager").GetComponent<SpawnManager>().enabled = false;
        }
    }

}
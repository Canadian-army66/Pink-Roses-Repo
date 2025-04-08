using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public bool theyGone;
    private int enemiesInScene;
    void Start()
    {
        var go = new GameObject { name = "StateManager" };
        DontDestroyOnLoad(go);
        enemiesInScene = GameObject.FindGameObjectsWithTag("Enemy").Length;
        TurnOff();
        theyGone = false;
    }

    void Update()
    {
        noEnemies();
    }
    public void TurnOff()
    {
        if (theyGone == true)
        {
            GameObject.FindWithTag("spawnManager").GetComponent<SpawnManager>().enabled = false;
            Console.WriteLine("Spawner is off");
        }
    }
    public void noEnemies()
    {
        if (enemiesInScene == 0)
        {
            theyGone = true;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCounter : MonoBehaviour
{
    public int enemyCount;
    void Update()
    {
        CountEnemies();
    }

    void CountEnemies()
    {
        int enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        Debug.Log("Number of Enemies: " + enemyCount);
    }
}

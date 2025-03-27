using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class EnemyCounter : MonoBehaviour
{
    public int enemyCount;
    public TextMeshProUGUI dialogueText;

    void Update()
    {
        CountEnemies();
    }

    void CountEnemies()
    {
        int enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        dialogueText.text = "Number of Enemies: " + enemyCount;
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool Spawning = true;
    public int numberToSpawn = 0;
    public GameObject SpawningPrefab;
    public BoundrySetter bound;
    void Update()
    {
        Spawner();
        Spawning = false;
    }

    public void Spawner()
    {
        if (Spawning == true)
        {
            for (int i = 0; i < numberToSpawn; i++)
            {
                Vector2 spawnPos = RandomSpawn();
                Instantiate(SpawningPrefab, spawnPos, Quaternion.identity);
            }
        }
    }
    public Vector2 RandomSpawn()
    {
        float x = Random.Range(bound.maxX, bound.minX);
        float y = Random.Range(bound.maxY, bound.minY);

        return new Vector2(x, y);

    }
}

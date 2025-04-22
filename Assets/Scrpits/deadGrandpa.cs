using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public GameObject objectToTransform;
    public GameObject objectToDestroy;
    public Vector3 newPosition;
    public Vector3 newScale;
    public Quaternion newRotation;
    public int enemyCount;

    void Start()
    {
        CountEnemies();
    }

    void Update()
    {
        Dead();
    }
    private void Dead()
    {
        if (enemyCount == 0)
        {
            Destroy(objectToDestroy);
            objectToTransform.transform.position = newPosition;
            objectToTransform.transform.localScale = newScale;
            objectToTransform.transform.rotation = newRotation;
            this.enabled = false;
        }
    }
    void CountEnemies()
    {
        int enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }

}
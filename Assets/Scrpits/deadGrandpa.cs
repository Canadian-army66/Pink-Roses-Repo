using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public GameObject objectToTransform;
    public GameObject objectToDestroy;
    public Vector3 newPosition;
    public Vector3 newScale;
    public Quaternion newRotation;

    private void OnTriggerEnter(Collider other)
    {
            Destroy(objectToDestroy);
            Destroy(this.gameObject);
            objectToTransform.transform.position = newPosition;
            objectToTransform.transform.localScale = newScale;
            objectToTransform.transform.rotation = newRotation;
    }
}
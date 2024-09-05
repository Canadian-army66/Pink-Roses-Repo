using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public GameObject objectToTransform; // Assign this via the Inspector
    public Vector3 newPosition; // Desired position after collision
    public Vector3 newScale; // Desired scale after collision
    public Quaternion newRotation; // Desired rotation after collision

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object has the "Player" tag
        if (collision.gameObject.CompareTag("Player"))
        {
            // Destroy this game object
            Destroy(gameObject);

            // Check if the objectToTransform is assigned
            if (objectToTransform != null)
            {
                // Transform the object
                objectToTransform.transform.position = newPosition;
                objectToTransform.transform.localScale = newScale;
                objectToTransform.transform.rotation = newRotation;
            }
        }
    }
}
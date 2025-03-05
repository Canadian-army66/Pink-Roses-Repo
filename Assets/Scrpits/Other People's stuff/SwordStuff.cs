using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordStuff : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("sword")) // Check if the object has the tag "sword"
        {
            MeshCollider swordCollider = other.GetComponent<MeshCollider>();

            if (swordCollider != null) // Ensure it has a MeshCollider
            {
                swordCollider.enabled = false;
                Debug.Log("Sword collider disabled.");
            }
            else
            {
                swordCollider.enabled = true;
            }
        }
    }
}

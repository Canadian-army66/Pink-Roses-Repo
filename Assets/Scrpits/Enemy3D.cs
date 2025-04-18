using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3D : MonoBehaviour
{
    private int brainDamage;
    public bool playerIsClose;
    private Animator mAnimator;
    public bool Dead;
    void Start()
    {
        mAnimator = GetComponent<Animator>();
        mAnimator.SetBool("isDead", false);
        GameObject.FindWithTag("Enemy").tag = "Enemy";

    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose && brainDamage < 10)
        {
            brainDamage++;
            mAnimator.SetBool("isHurt", true);
        }
        else
        {
            mAnimator.SetBool("isHurt", false);
        }

        if (brainDamage >= 10)
        {
            
            mAnimator.SetBool("isDead", true);
            this.enabled = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
        }
    }
}

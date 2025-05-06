using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Enemy3D : MonoBehaviour
{
    private int brainDamage;
    public bool playerIsClose;
    private Animator mAnimator;
    public bool Dead;
    public controls edMovement;
    void Start()
    {
        mAnimator = GetComponent<Animator>();
        mAnimator.SetBool("isDead", false);
        GameObject.FindWithTag("Enemy").tag = "Enemy";
    }

    
    void Update()
    {
        if (edMovement.isKicking && playerIsClose && brainDamage < 10)
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
            gameObject.tag = "Dead";
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

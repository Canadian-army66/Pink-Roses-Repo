using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToDoStuff : MonoBehaviour
{
    private Animator mAnimator;
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if(mAnimator != null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                mAnimator.SetTrigger("ToKick");
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                mAnimator.SetTrigger("ToWalk");
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                mAnimator.SetTrigger("ToWalk");
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                mAnimator.SetTrigger("ToWalk");
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                mAnimator.SetTrigger("ToWalk");
            }
        }
    }
}

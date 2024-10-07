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
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.W))
            {
                mAnimator.SetTrigger("ToWalk");
            }
            else if(mAnimator.GetBool("ToIdle") == false)
            {
                mAnimator.SetBool("ToIdle", true);
            }
        }
    }
}

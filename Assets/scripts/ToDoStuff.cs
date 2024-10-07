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
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W))
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

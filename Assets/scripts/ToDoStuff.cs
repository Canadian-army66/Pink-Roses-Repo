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
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.W))
            {
                mAnimator.SetTrigger("ToWalk");
            }
            if (Input.GetKey(KeyCode.D))
            {
                mAnimator.SetTrigger("ToWalk");
                transform.localScale = new Vector3(-6,6,1);
            }
            if (Input.GetKey(KeyCode.A))
            {
                mAnimator.SetTrigger("ToWalk");
                transform.localScale = new Vector3(6, 6, 1);
            }
            else if(mAnimator.GetBool("ToIdle") == false)
            {
                mAnimator.SetBool("ToIdle", true);
            }
        }
    }
}

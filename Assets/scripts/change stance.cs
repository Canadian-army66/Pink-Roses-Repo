using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changestance : MonoBehaviour
{
    private Animator mAnimator;
    public GameObject dialoguePanel;
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (mAnimator != null)
        {
            if (dialoguePanel.activeInHierarchy)
            {
                mAnimator.SetBool("isTalking", true);
            }
            else
            {
                mAnimator.SetBool("isTalking", false);
            }
        }
    }
}

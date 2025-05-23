using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public int speed = 1;
    private Animator mAnimator;
    private Rigidbody2D characterBody;
    private Vector2 velocity;
    private Vector2 inputMovement;
    public BoundrySetter bound;
    public Vector3 PostScale;
    public Vector3 PreScale;
    public AudioClip kickSound;
    private AudioSource audioSource;
    public bool isKicking;
    void Start()
    {
        velocity = new Vector2(speed, speed);
        characterBody = GetComponent<Rigidbody2D>();
        Cursor.visible = false;
        mAnimator = GetComponent<Animator>();
        audioSource = gameObject.AddComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bound.minY)
        {
            transform.position = new Vector3(transform.position.x, bound.minY, 0);
        }
        else if (transform.position.y > bound.maxY)
        {
            transform.position = new Vector3(transform.position.x, bound.maxY, 0);
        }
        if (transform.position.x < bound.minX)
        {
            transform.position = new Vector3(bound.minX, transform.position.y, 0);
        }
        else if (transform.position.x > bound.maxX)
        {
            transform.position = new Vector3(bound.maxX, transform.position.y, 0);
        }

        if (mAnimator != null)
        {
            if (isKicking)
            {
                audioSource.Play();
                mAnimator.SetTrigger("ToKick");
            }
            if (inputMovement.y != 0)
            {
                mAnimator.SetTrigger("ToWalk");
            }
            if (inputMovement.x > 0)
            {
                mAnimator.SetTrigger("ToWalk");
                transform.localScale = PreScale;
            }
            if (inputMovement.x < 0)
            {
                mAnimator.SetTrigger("ToWalk");
                transform.localScale = PostScale;
            }
            else if (mAnimator.GetBool("ToIdle") == false)
            {
                mAnimator.SetBool("ToIdle", true);
            }
        }
    }
    private void FixedUpdate()
    {
        Vector2 delta = inputMovement * velocity * Time.deltaTime;
        Vector2 newPosition = characterBody.position + delta;
        characterBody.MovePosition(newPosition);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.forward * 500);
    }

    public void OnKick(InputValue value)
    {
        isKicking = value.isPressed;
    }
    public void OnMove(InputValue inputValue)
    {
        inputMovement = inputValue.Get<Vector2>();
    }
    public void MoveInput(Vector2 input)
    {
        inputMovement = input.normalized;
    }

    public void KickInput(bool input)
    {
        isKicking = input;
    }
}

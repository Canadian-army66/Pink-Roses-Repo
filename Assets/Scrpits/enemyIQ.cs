using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWander : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float changeDirectionTime = 2f;
    private float timer;
    public Vector2 moveDirection;
    public BoundrySetter bound;
    private int brainDamage;
    public bool playerIsClose;
    private Animator mAnimator;
    public bool Dead;
    private PlayerMovement playerMovement;

    void Start()
    {
        SetRandomDirection();
        timer = changeDirectionTime;
        mAnimator = GetComponent<Animator>();
        mAnimator.SetBool("isDead", false);
        GameObject.FindWithTag("Enemy").tag = "Enemy";
        bound = GameObject.FindWithTag("map").GetComponent<BoundrySetter>();
        playerMovement = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SetRandomDirection();
            timer = changeDirectionTime;
        }

        Move();

        if (playerMovement.isKicking && playerIsClose && brainDamage < 10)
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
            StopAllCoroutines();
            mAnimator.SetBool("isDead", true);
            GameObject.FindWithTag("Enemy").tag = "Dead";
            this.enabled = false;
        }
    }

    void SetRandomDirection()
    {
        moveDirection = Random.insideUnitCircle.normalized;
    }

    void Move()
    {
        Vector3 newPosition = transform.position + (Vector3)moveDirection * moveSpeed * Time.deltaTime;
        newPosition = ClampToBounds(newPosition);
        transform.position = newPosition;
    }

    Vector3 ClampToBounds(Vector3 position)
    {
        position.x = Mathf.Clamp(position.x, bound.minX, bound.maxX);
        position.y = Mathf.Clamp(position.y, bound.minY, bound.maxY);
        return position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("wall"))
        {
            SetRandomDirection();
        }
    }
}

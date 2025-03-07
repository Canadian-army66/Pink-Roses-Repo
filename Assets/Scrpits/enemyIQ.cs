using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWander : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float changeDirectionTime = 2f;
    private float timer;
    private Vector2 moveDirection;
    public BoundrySetter bound;
    private int brainDamage;
    public bool playerIsClose;
    private Animator mAnimator;

    void Start()
    {
        SetRandomDirection();
        timer = changeDirectionTime;
        mAnimator.SetBool("isDead", false);
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

        if (Input.GetKeyDown(KeyCode.E) && playerIsClose && brainDamage < 10)
        {
            brainDamage++;
            mAnimator.SetBool("Hurt", true);
        }

        if (brainDamage >= 20 && playerIsClose)
        {
            StopAllCoroutines();
            mAnimator.SetBool("isDead", true);
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

}

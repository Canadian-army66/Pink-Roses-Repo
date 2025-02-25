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

    void Start()
    {
        SetRandomDirection();
        timer = changeDirectionTime;
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
}

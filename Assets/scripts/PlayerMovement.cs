using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int speed = 1;
    private Rigidbody2D characterBody;
    private Vector2 velocity;
    private Vector2 inputMovement;
    public BoundrySetter bound;
    void Start()
    {
        velocity = new Vector2(speed, speed);
        characterBody = GetComponent<Rigidbody2D>();
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        inputMovement = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
            );
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
    }
    private void FixedUpdate()
    {
        Vector2 delta = inputMovement * velocity * Time.deltaTime;
        Vector2 newPosition = characterBody.position + delta;
        characterBody.MovePosition(newPosition);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundrySetter : MonoBehaviour
{
    public float speed;
    public PolygonCollider2D bounds;
    public float minX, minY, maxX, maxY;
    void Start()
    {
        transform.position = new Vector3 (0, 0, 0);
            foreach(Vector2 point in bounds.points)
        {
            if (point.x < minX)
                minX = point.x;
            if (point.y < minY)
                minY = point.y;
            if (point.x > maxX)
                maxX = point.x;
            if (point.y > maxY)
                maxY = point.y;
        }
    }

    void Update()
    {
        

    }
}

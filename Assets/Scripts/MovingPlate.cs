using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlate : MonoBehaviour
{
   /* public Transform point1, point2;
    public float speed;
    public Transform startPoint;
    Vector3 nextPoint;*/

    float dirX, moveSpeed = 3f;
    bool moveRight = true;
    // Start is called before the first frame update8

    void Start()
    {
       /*nextPoint = startPoint.position;*/
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > 4f)
        {
            moveRight = false;
        }
        if(transform.position.x < -2f)
        {
            moveRight = true;
        }

        if (moveRight)
        {
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
        }

        /*if (transform.position == point1.position)
        {
            nextPoint = point2.position;
        }
        if (transform.position == point2.position)
        {
            nextPoint = point1.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPoint, speed * Time.deltaTime);*/

    }

}

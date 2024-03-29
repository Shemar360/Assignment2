using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private Rigidbody2D rBody;

    private bool isLaunchpad;
    private bool isGrounded;
    public Transform bottom;
    public float checkRadius;
    public LayerMask whatIsGround;
    public LayerMask whatIsJumpBoost;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horiz = Input.GetAxis("Horizontal");

        rBody.velocity = new Vector2(horiz * speed, rBody.velocity.y);

    }

    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(bottom.position, checkRadius, whatIsGround);

        if (isGrounded == true && (Input.GetKeyDown(KeyCode.Space) || (Input.GetKeyDown(KeyCode.W) || (Input.GetKeyDown(KeyCode.UpArrow)))))
        {
            rBody.velocity = Vector2.up * jumpForce;
        }

        isLaunchpad = Physics2D.OverlapCircle(bottom.position, checkRadius, whatIsJumpBoost);
        if (isLaunchpad == true && (Input.GetKeyDown(KeyCode.Space) || (Input.GetKeyDown(KeyCode.W) || (Input.GetKeyDown(KeyCode.UpArrow)))))
        {
            {
                rBody.velocity = Vector2.up * 15;
            }
        }
    }
}

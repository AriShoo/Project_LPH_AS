using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public float jumpForce = 1000f;
    public string groundTag = "Ground";

    private bool touchingGround = false;
    private bool attemptJump = false;

    private bool isJumping;
    private Rigidbody2D RB;

    private void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    public void Jumps()
    {
        attemptJump = true;
        Debug.Log("Button pressed");
    }
    public void FixedUpdate()
    {
        if (attemptJump)
        {
            if (touchingGround == true)
            {

                Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();
                ourRigidbody.AddForce(Vector2.up * jumpForce);
            }

            attemptJump = false;
        }

        touchingGround = false;

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            RB.AddForce(new Vector2(RB.velocity.x, jumpForce));
            isJumping = true;
        }
    }

    public void OnCollisionStay2D(Collision2D collision)
    {

        if (collision.collider.CompareTag(groundTag) == true)
        {
            touchingGround = true;
            isJumping = false;
            Debug.Log("Touching ground");
        }

        if (isJumping == true)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
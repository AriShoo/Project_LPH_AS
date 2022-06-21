using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
   
    public float jumpForce = 1000f;
    public string groundTag = "Ground";

    private bool touchingGround = false;
    private bool attemptJump = false;

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
    }

    public void OnCollisionStay2D(Collision2D collision)
    {
        
        if (collision.collider.CompareTag(groundTag) == true)
        {
           touchingGround = true;
            Debug.Log("Touching ground");
        }
    }
}
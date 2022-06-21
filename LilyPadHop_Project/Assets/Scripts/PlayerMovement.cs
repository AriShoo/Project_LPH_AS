using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    public float jumpSpeed = 50;
    private Rigidbody2D ourRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();

        //physicsBody.velocity = new Vector2(2,0);
    }

    // Update is called once per frame
    void Update()
    {
        float axisValY = Input.GetAxis("Vertical"); 
        float axisValX = Input.GetAxis("Horizontal");

        //physicsBody.velocity = new Vector2(axisValX * speed, axisValY * speed);
    }

    // Programmer defined function, not part of unity
    // To be called by the button
    // Public = Accessible outside of this script
    public void MoveRight()
    {
        // Use the rigidbody, set the velocity to a vector pointing right at magnitude of speed
        ourRigidbody.velocity = new Vector2(speed, 0);
    }
    public void MoveLeft()
    {
        // Use the rigidbody, set the velocity to a vector pointing right at magnitude of speed
        ourRigidbody.velocity = new Vector2(-speed, 0);
    }
   // public void Jump()
   // {
        // Use the rigidbody, set the velocity to a vector pointing right at magnitude of speed
       // ourRigidbody.velocity = new Vector2(0, jumpSpeed);
   // }
}

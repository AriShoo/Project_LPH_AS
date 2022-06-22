using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaspPatrol : MonoBehaviour
{

    public float forceStrength;
    public Vector2 patrolPoint;

    private Rigidbody2D ourRigidbody;

    void Awake()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = (patrolPoint - (Vector2)transform.position).normalized;
        direction = direction.normalized;

        ourRigidbody.AddForce(direction * forceStrength);
    }
}

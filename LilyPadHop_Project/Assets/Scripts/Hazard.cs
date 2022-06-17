using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Purpose: Whenever our player touches the object this hazard script is attached to delete the player
public class Hazard : MonoBehaviour
{

    public int hazardDamage = 10;

    // Condition: Whenever the player touches this: 
    private void OnCollisionEnter2D(Collision2D collision)
    {
       PlayerHealth healthScript =  collision.gameObject.GetComponent<PlayerHealth>();
        healthScript.Kill(); // null if the health script isn't there

        // If the thing we touched is the player: 
        if (healthScript != null)
        {
            // Kill the player
            //healthScript.Kill();

            healthScript.ChangeHealth(-10);

        }

    }
}

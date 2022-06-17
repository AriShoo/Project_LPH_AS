using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100; // able to be edited in unity
    private int currentHealth = 0;

    //
    //
    private void Awake()
    {
        currentHealth = startingHealth;
    }

    public void Kill()
    {
        // Destroy will delete/remove a game object from the game
        // "gameObject" is the Game Object that this script is attached to
        //Destroy(gameObject);

        // Alt: Game over
        //SceneManager.LoadScene("GameOver");

        // Alt: Reload current scene
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene); 

    }

    public void ChangeHealth(int changeAmount)
    {
        currentHealth = currentHealth + changeAmount;
        if (currentHealth >= 0)
        {
            Kill();
        }
    }

}

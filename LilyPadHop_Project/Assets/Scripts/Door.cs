using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
      private void OnTriggerEnter2D(Collider2D collision)
      {
        if (collision.CompareTag("Player"))
        {
            // The thing we ran into had the Player tag

            SceneManager.LoadScene("WinScreen");

        }
      }

}

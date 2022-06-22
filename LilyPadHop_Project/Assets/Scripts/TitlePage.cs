using UnityEngine;
using UnityEngine.SceneManagement;


public class TitlePage : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("TitleScreenMenu");
    }
}
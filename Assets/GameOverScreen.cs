using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    // Add any necessary variables here

    void Start()
    {
        // Initialize variables and set up the UI
    }

    public void RestartGame()
    {
        // Code to restart the game
        SceneManager.LoadScene("Asteroids");
    }

    public void MainMenu()
    {
        // Code to return to the main menu
        SceneManager.LoadScene("MainMenu");
    }
}

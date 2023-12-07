using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public GameObject gameOverUI;
    // Start is called before the first frame update
    public void RestartGame()
    {
        // Code to restart the game
        Time.timeScale = 1f;
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }

    public void MainMenu()
    {
        // Code to return to the main menu
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}


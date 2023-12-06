using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public void PlayGame () {
        SceneManager.LoadScene("Asteroids"); // Play Button: loads the next scene
    }

    public void QuitGame() {
        Debug.Log ("QUIT!"); // Discplays "QUIT!" message in the Unity console
        Application.Quit(); // Closes down the program
    }

}

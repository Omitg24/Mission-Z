using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{    

    public void PlayGame() {
        SceneManager.LoadScene("Cinematic");
        Debug.Log("Playing Mission-Z");
    }

    public void QuitGame() {
        Application.Quit();
        Debug.Log("Exiting Mission-Z");
    }

    public void BackMenu() {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Returning to the main menu");
    }
}

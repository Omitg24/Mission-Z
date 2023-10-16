using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{    

    public void PlayGame() {
        SceneManager.LoadScene("Game");
        Debug.Log("Playing Mission-Z");
    }

    public void QuitGame() {
        Application.Quit();
        Debug.Log("Exiting Mission-Z");
    }
}

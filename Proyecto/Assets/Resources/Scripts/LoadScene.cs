using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    public string scene;

    // Start is called before the first frame update
    void Start()
    {       
    }

    // Update is called once per frame
    void Update()
    {        
    }

    public void LoadEndingScene() {
        SceneManager.LoadScene(scene);
        Debug.Log("Loading scene: " + scene);
    }
}

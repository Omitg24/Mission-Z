using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeCScene : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadNextScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoadNextScene() {
        yield return new WaitForSeconds(6f);

        SceneManager.LoadScene("Game");
    }
}

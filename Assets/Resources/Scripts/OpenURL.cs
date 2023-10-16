using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    public string url = "https://github.com/Omitg24";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerCLick() {
        Debug.Log("Opening URL..." + url);
        Application.OpenURL(url);
    }
}

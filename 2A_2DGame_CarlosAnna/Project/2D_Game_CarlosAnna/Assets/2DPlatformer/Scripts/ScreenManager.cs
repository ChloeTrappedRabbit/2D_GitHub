using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{

    public int nextScene;
    public int backScene;
    public int currentScene;

    // Update is called once per frame
    void Start()
    {

    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.N))
        {
            Application.LoadLevel(nextScene);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            Application.LoadLevel(backScene);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(currentScene);
        }
    }
}

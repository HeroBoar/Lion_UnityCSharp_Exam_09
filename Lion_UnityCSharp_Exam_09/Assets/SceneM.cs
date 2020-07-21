using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneM : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            //Application.loadedLevel()
            SceneManager.LoadScene(Application.loadedLevel + 1);
        }
        if (Input.GetKeyDown(KeyCode.O))
        { 
            SceneManager.LoadScene(Application.loadedLevel - 1);
        }
    }
}

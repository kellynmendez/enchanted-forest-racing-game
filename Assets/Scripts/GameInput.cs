using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInput : MonoBehaviour
{
    void Update()
    {
        // Backspace key causes leve reset
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            // Determine current scene
            int currentLevelIndex = SceneManager.GetActiveScene().buildIndex;
            // Reload that scene
            SceneManager.LoadScene(currentLevelIndex);
        }
        // Escape key exits application
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Exit the game");
            Application.Quit();
        }

    }
}

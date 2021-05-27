using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartButton()
    {
        // Load game scene
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitButton()
    {
        // Quits the game
        Application.Quit();
    }
}

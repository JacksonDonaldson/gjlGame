using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("level1");
    }

    public void quitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}

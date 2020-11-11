using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
     void OnRunGameStartClick()
    {
       // SceneManager.LoadScene("_Scene_0");
        SceneManager.LoadScene("_Scene_0");
    }

     void OnExitGame()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnRunGameStartClick()
    {
        SceneManager.LoadScene("_Scene_0");
       // SceneManager.LoadScene(0);
    }

     void OnExitGame()
    {
        Application.Quit();
    }
}

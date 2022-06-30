using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public void StartGame()
    {

        SceneManager.LoadScene("Prototype 1");
    }

    public void QuitGame ()

    {

        Application.Quit();
    }

}
    

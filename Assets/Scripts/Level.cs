using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
 public void ReloadLevel()
    {
        SceneManager.LoadScene(0);
        //SceneManager.LoadScene("GameeScene");

    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
        ResumeGame();

    }

    public void LoadSettings()
    {
        SceneManager.LoadScene(2);
        ResumeGame();

    }



    private void Exit() { Application.Quit(); }
    
    private void ResumeGame() { Time.timeScale = 1; }

}

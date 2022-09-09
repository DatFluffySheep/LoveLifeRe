using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject PauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (GameIsPaused == true)
                Resume();
            else if (GameIsPaused == false)
                Pause();
        }
    }

    public void Resume()
    {
        Debug.Log("Game Resume");
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        Debug.Log("Game is paused");
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void QuitGame()
    {
        Debug.Log("Quitting the game...");
        Application.Quit();
    }
}

/* if adding to audio manager
 * in public void Play
 * if(PauseMenu GameIsPause()
 * s.source.pitch *= .5f;
 */
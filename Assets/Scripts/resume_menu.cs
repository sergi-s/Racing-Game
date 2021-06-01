using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resume_menu : MonoBehaviour
{
    public GameObject PMenu;
    bool GameIsPaused = false;
    public AudioSource beeb;

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            beeb.Play();
        }
        
    }
    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void EndGame()
    {
        Application.Quit();
    }
    public void Resume()
    {
        PMenu.SetActive(false);
        GameIsPaused = false;
        Time.timeScale = 1;
    }
    public void Pause()
    {
        PMenu.SetActive(true);
        GameIsPaused = true;
        Time.timeScale = 0;
    }


}

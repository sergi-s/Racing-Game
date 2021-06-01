using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOptions : MonoBehaviour
{
   
    public void TrackSelecter()
    {
        SceneManager.LoadScene(1);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    //blow here are track selection buttons
    public void Track01()
    {
        SceneManager.LoadScene(2);
    }
    public void Track02()
    {
        SceneManager.LoadScene(3);
    }
    public void Track03()
    {
        SceneManager.LoadScene(4);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ResetPref()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetFloat("RawTime",100000);
        GlobelCash.Totalcash = 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;


public class RaceFinsh : MonoBehaviour
{
    public GameObject MyCar;
    public GameObject FinshCam;
    public GameObject ViewMode;
    public GameObject levelMusic;
    public GameObject completetrig;
    public AudioSource finishMusic;

    private void OnTriggerEnter()
    {
        if (ModeTime.isTimeMode)
        {
            Debug.Log("This is the Time Mode");
        }
        else
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MyCar.SetActive(false);
            completetrig.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            MyCar.GetComponent<CarController>().enabled = false;
            MyCar.GetComponent<CarUserControl>().enabled = false;
            MyCar.SetActive(true);
            FinshCam.SetActive(true);
            levelMusic.SetActive(false);
            ViewMode.SetActive(false);
            finishMusic.Play();
            CarController.m_Topspeed = 100f;
        }


    }
    
}

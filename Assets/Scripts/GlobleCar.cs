using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobleCar : MonoBehaviour
{
    public GameObject TrackWindow;
    public static int CarType;//1 reda, 2 blue
    public void RedCar()
    {
        CarType = 1;
        TrackWindow.SetActive(true);
    }
    public void BlueCar()
    {
        CarType = 2;
        TrackWindow.SetActive(true);
    } 
}

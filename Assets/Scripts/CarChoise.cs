using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoise : MonoBehaviour
{
    //1 red,2 blue
    public GameObject RedBody;
    public GameObject BlueBody;
    public int CarImport;
    void Start()
    {
        CarImport = GlobleCar.CarType;
        if (CarImport == 1)
        {
            RedBody.SetActive(true);
        }
        if(CarImport==2)
        {
            BlueBody.SetActive(true);
        }
    }

   
}

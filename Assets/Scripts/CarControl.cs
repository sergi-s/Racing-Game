using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    public GameObject CarControls;
    void Start()
    {
        (GetComponent("CarController") as CarControl).enabled = true;
    }

}

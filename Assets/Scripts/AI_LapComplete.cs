using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_LapComplete : MonoBehaviour
{

    public GameObject ailapcompletetrig;
    public GameObject aihalflaptrig;
    public static int AICompletedLaps;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "DreamCar01")
        {
            AICompletedLaps++;
        }
        aihalflaptrig.SetActive(true);
        ailapcompletetrig.SetActive(false);
    }
}

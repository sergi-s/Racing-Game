using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIHalfpointTrigger : MonoBehaviour
{
    public GameObject ailapcompletetrig;
    public GameObject aihalflaptrig;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("DreamCar01"))
        {
            ailapcompletetrig.SetActive(true);
            aihalflaptrig.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfpointTrigger : MonoBehaviour
{
    public GameObject lapcompletetrig; 
    public GameObject halflaptrig;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("MyCar"))
        {
            lapcompletetrig.SetActive(true);
            halflaptrig.SetActive(false);
        }
    }

}

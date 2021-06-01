using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bariar : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position= new Vector3(138, 0, 352);
    }
}

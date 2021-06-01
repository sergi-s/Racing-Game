using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamCar01Track : MonoBehaviour
{
    public GameObject themarker;
    public GameObject mark01;
    public GameObject mark02;
    public GameObject mark03;
    public GameObject mark04;
    public GameObject mark05;
    public GameObject mark06;
    public GameObject mark07;
    public GameObject mark08;
    public GameObject mark09;
    
    public int marktracker;


    void Update()
    {
        if (marktracker == 0)
        {
            themarker.transform.position = mark01.transform.position;
        }
        if (marktracker == 1)
        {
            themarker.transform.position = mark02.transform.position;
        }
        if (marktracker == 2)
        {
            themarker.transform.position = mark03.transform.position;
        }
        if (marktracker == 3)
        {
            themarker.transform.position = mark04.transform.position;
        }
        if (marktracker == 4)
        {
            themarker.transform.position = mark05.transform.position;
        }
        if (marktracker == 5)
        {
            themarker.transform.position = mark06.transform.position;
        }
        if (marktracker == 6)
        {
            themarker.transform.position = mark07.transform.position;
        }
        if (marktracker == 7)
        {
            themarker.transform.position = mark08.transform.position;
        }
        if (marktracker == 8)
        {
            themarker.transform.position = mark09.transform.position;
        }
        
        

    }

    IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DreamCar01")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            marktracker++;
            if (marktracker == 9)
            {
                marktracker = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;

        }
    }
}

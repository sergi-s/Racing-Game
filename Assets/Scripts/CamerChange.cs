using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerChange : MonoBehaviour
{
    public GameObject NormalCam;
    public GameObject FarCam;
    public GameObject fpCam;
    public int CamMode;
    void Update()
    {
        if (Input.GetButtonDown("ViewMode"))
        {
            if (CamMode == 2)
            {
                CamMode = 0;
            }
            else
            {
                CamMode++;
            }
            StartCoroutine(modechange());
        }
    }
    IEnumerator modechange()
    {
        yield return new WaitForSeconds(0.01f);
        if (CamMode == 0)
        {
            NormalCam.SetActive(true);
            fpCam.SetActive(false);
        }
        if (CamMode == 1)
        {
            FarCam.SetActive(true);
            NormalCam.SetActive(false);
        }
        if (CamMode == 2)
        {
            fpCam.SetActive(true);
            FarCam.SetActive(false);
        }
    }
}

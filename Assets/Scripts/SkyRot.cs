using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyRot : MonoBehaviour
{
    public float RotateSpeed=0.5f;
    

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", RotateSpeed * Time.time);
    }
}

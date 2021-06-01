using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueScore : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        ModeScore.CurrentScore += 50;
        gameObject.SetActive(false);
    }
}

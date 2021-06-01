using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackScore : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        ModeScore.CurrentScore += 100;
        gameObject.SetActive(false);
    }
}

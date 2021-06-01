using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public GameObject countdown;
    public AudioSource getReady;
    public AudioSource goAudio;
    public GameObject lapTimer;
    public GameObject blocker;
    public AudioSource levelmusic;

    void Start()
    {
        StartCoroutine(CountStart());
    }

    IEnumerator CountStart()
    {
            
        yield return new WaitForSeconds(0.5f);
        countdown.GetComponent<Text>().text = "3";
        getReady.Play();
        countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        countdown.SetActive(false);
        countdown.GetComponent<Text>().text = "2";
        getReady.Play();
        countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        countdown.SetActive(false);
        countdown.GetComponent<Text>().text = "1";
        getReady.Play();
        countdown.SetActive(true);
        yield return new WaitForSeconds(1); 
        countdown.SetActive(false);
        goAudio.Play();
        levelmusic.Play();
        lapTimer.SetActive(true);
        blocker.SetActive(false);
    }

    
}

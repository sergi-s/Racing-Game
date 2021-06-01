using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LapCompelet : MonoBehaviour
{
    public GameObject lapcompletetrig;
    public GameObject halflaptrig;

    public GameObject miniutdisplay;
    public GameObject seconddisplay;
    public GameObject milidisplay;
    
    public GameObject lapcounter;
    public int lapsDone;

    public float RawTime;

    public GameObject RaceFinsh;

    public GameObject GameOver;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(AI_LapComplete.AICompletedLaps);
        if (other.gameObject.tag == ("MyCar"))
        {
            lapsDone++;
            RawTime = PlayerPrefs.GetFloat("RawTime");
            
            if (lapsDone == 2 && AI_LapComplete.AICompletedLaps<2)
            {
                RaceFinsh.SetActive(true);
                GameOver.GetComponent<Text>().text = "You Win";
            }
            else if(lapsDone == 2 && AI_LapComplete.AICompletedLaps >= 2)
            {
                RaceFinsh.SetActive(true);
                GameOver.GetComponent<Text>().text = "You Lose";
            }
            if (LapTimeManger.RawTime <= RawTime)
            {
                if (LapTimeManger.secondcount<= 9)
                {
                    seconddisplay.GetComponent<Text>().text = "0" + LapTimeManger.secondcount + ".";
                }
                else
                {
                    seconddisplay.GetComponent<Text>().text = "" + LapTimeManger.secondcount + ".";
                }

                if (LapTimeManger.minutecount <= 9)
                {
                    miniutdisplay.GetComponent<Text>().text = "0" + LapTimeManger.minutecount + ".";
                }
                else
                {
                    miniutdisplay.GetComponent<Text>().text = "" + LapTimeManger.minutecount+ ".";
                }

                milidisplay.GetComponent<Text>().text = "" + LapTimeManger.millicount;
                PlayerPrefs.SetFloat("RawTime", LapTimeManger.RawTime);

            }
            PlayerPrefs.SetInt("MinSave", LapTimeManger.minutecount);
            PlayerPrefs.SetInt("SecSave", LapTimeManger.secondcount);
            PlayerPrefs.SetFloat("MilliSave", LapTimeManger.millicount);

            LapTimeManger.minutecount = 0;
            LapTimeManger.secondcount = 0;
            LapTimeManger.millicount = 0;
            LapTimeManger.RawTime = 0;

            lapcounter.GetComponent<Text>().text = "" + lapsDone;
            halflaptrig.SetActive(true);
            lapcompletetrig.SetActive(false);
        }
    } 
}

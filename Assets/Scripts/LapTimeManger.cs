using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LapTimeManger : MonoBehaviour
{

    public static int minutecount;
    public static int secondcount;
    public static float millicount;
    public static string MilliDisplay;

    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;

    public static float RawTime;

    // Update is called once per frame
    void Update()
    {
        millicount += Time.deltaTime * 10;
        RawTime += Time.deltaTime;
        MilliDisplay = millicount.ToString("F0");
        MilliBox.GetComponent<Text>().text=""+MilliDisplay;

        if (millicount >= 10)
        {
            millicount = 0;
            secondcount++;
        }
        if (secondcount <= 9)
        {
            SecondBox.GetComponent<Text>().text = "0" + secondcount + ".";

        }
        else
        {
            SecondBox.GetComponent<Text>().text =""+secondcount + ".";
        }
        if (secondcount >= 60)
        {
            secondcount = 0;
            minutecount++;
        }
        if (minutecount <= 9)
        {
            MinuteBox.GetComponent<Text>().text = "0" + minutecount+":";
        }
        else
        {
            MinuteBox.GetComponent<Text>().text = "" + minutecount + ":";
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobelCash : MonoBehaviour
{
    public int CashValue;
    public static int Totalcash;
    public GameObject CashDisplay;
    void Start()
    {
        Totalcash = PlayerPrefs.GetInt("SavedCash");
    }

    // Update is called once per frame
    void Update()
    {
        CashValue = Totalcash;
        CashDisplay.GetComponent<Text>().text = "Cash $" + CashValue;
    }
}

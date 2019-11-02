using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalGrandma : MonoBehaviour
{

    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int GrandmaValue = 10;
    public GameObject GrandmaStats;
    public static int numberOfGrandmas;
    public static int GrandmaPerSec;

    void Update()
    {
        currentCash = GlobalCash.CashCount;
        GrandmaStats.GetComponent<Text>().text = "Grandmas: " + numberOfGrandmas + " @ " + GrandmaPerSec + " Per Secodns";
        fakeText.GetComponent<Text>().text = "Grandma The Cookie Master - $" + GrandmaValue;
        realText.GetComponent<Text>().text = "Grandma The Cookie Master - $" + GrandmaValue;

        if (currentCash >= GrandmaValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);

        }else if(currentCash < GrandmaValue)
        {
            fakeButton.SetActive(true);
            realButton.SetActive(false);
        }
    }
}

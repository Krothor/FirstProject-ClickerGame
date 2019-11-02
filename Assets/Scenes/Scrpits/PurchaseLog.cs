using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject CookieMaker;
    public AudioSource playSound;

    public void StartCookieMaker()
    {
        playSound.Play();
        CookieMaker.SetActive(true);
        GlobalCash.CashCount -= GlobalGrandma.GrandmaValue;
        GlobalGrandma.GrandmaValue *= 2;
        GlobalGrandma.GrandmaPerSec += 1;
        GlobalGrandma.numberOfGrandmas += 1;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieMaker : MonoBehaviour
{

    public bool CreatingCookie = false;
    public static int CookieIncrese = 1;
    public int InternalIncrease;


    void Update()
    {
        CookieIncrese = GlobalGrandma.GrandmaPerSec;
        InternalIncrease = CookieIncrese;
        if(CreatingCookie == false)
        {
            CreatingCookie = true;
            StartCoroutine(CreateTheCookie());
        }
        
    }
    IEnumerator CreateTheCookie ()
    {
        GlobalCookies.CookieCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingCookie = false;
    }
}

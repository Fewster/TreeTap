using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class GameManager
{
    public static float TreeCount;
    public static float DonationCount;

    public static float InfluenceTotal;

    public static string counterText;
    public static string influenceCount;
    public static string donationCount;

    //Each tap a tree is planted
    public static void IncrementTreeCount()
    {
        if (TapModifier.tapModifier == 0)
        {
            TreeCount = TreeCount + 1;
        }
        else
        {
            TreeCount = TreeCount + TapModifier.tapModifier;
        }

        Debug.Log("TreeCount "+TreeCount);

    }

    //Each tree provides 0.01 influence per min
    public static void IncrementInfluenceCount()
    {
        float donationProvider = 0;

        

        Debug.Log("InfluenceCount "+ InfluenceTotal);

        if (donationProvider >= 10)
        {
            IncrementDonationCount();
        }
    }

    //Every 1 influence provides 10 donations
    public static void IncrementDonationCount()
    {
        Debug.Log("DonationCount "+DonationCount);
    }

    public static float GetInfluencePerMin()
    {
        //needs to be calculated per/min
        var num = InfluenceModifier.OnChange_InfluenceModifier();
        var influencePerMin = TreeCount * num;

        return influencePerMin;
    }


}

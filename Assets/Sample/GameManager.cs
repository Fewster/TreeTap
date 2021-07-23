using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager 
{
    public float TreeCount;
    public float DonationCount;

    public float InfluenceTotal;

    public string counterText;
    public string influenceCount;
    public string donationCount;

    //Each tap a tree is planted
    public void IncrementTreeCount()
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
    public void IncrementInfluenceCount()
    {
        float donationProvider = 0;

        

        Debug.Log("InfluenceCount "+ InfluenceTotal);

        if (donationProvider >= 10)
        {
            IncrementDonationCount();
        }
    }

    //Every 1 influence provides 10 donations
    public void IncrementDonationCount()
    {
        Debug.Log("DonationCount "+ DonationCount);
    }

    public float GetInfluencePerMin()
    {
        //needs to be calculated per/min
        var num = InfluenceModifier.OnChange_InfluenceModifier();
        var influencePerMin = TreeCount * num;

        return influencePerMin;
    }


}

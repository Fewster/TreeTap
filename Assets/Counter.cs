using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Button mainButton;
    public GameObject treeObject;

    [Space]
    public Text treePlantedText;
    public Text influenceText;
    public Text donationsText;

    private float time = 0;
    private float influenceCounter;

    public void onTap()
    {
        GameManager.IncrementTreeCount();

        treePlantedText.text = GameManager.TreeCount + " Tree's Planted.";
    }

    public void onInfluence()
    {
        influenceText.text = influenceCounter + " Influence.";
    }

    public void onDonation()
    {
        donationsText.text = GameManager.DonationCount + " Donations.";
    }

    private void Update()
    {
        if(GameManager.TreeCount >= 1)
        {
            time += Time.deltaTime;
            var ttl = 10f;
            Debug.Log(time);

            if (time >= ttl)
            {
                influenceCounter = GameManager.GetInfluencePerMin();
                Debug.LogError($"influenceCounter {influenceCounter}");
                time = 0;
            }
        }
    }
}

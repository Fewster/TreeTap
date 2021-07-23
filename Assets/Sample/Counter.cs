using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Button mainButton;
    public GameObject treeObject;
    private GameManager manager;

    [Space]
    public Text treePlantedText;
    public Text influenceText;
    public Text donationsText;

    private float time = 0;
    private float influenceCounter;

    public void OnTap()
    {
        manager.IncrementTreeCount();

        treePlantedText.text = manager.TreeCount + " Tree's Planted.";
    }

    public void OnInfluence()
    {
        influenceText.text = influenceCounter + " Influence.";
    }

    public void OnDonation()
    {
        donationsText.text = manager.DonationCount + " Donations.";
    }

    private void Update()
    {
        if(manager.TreeCount >= 1)
        {
            time += Time.deltaTime;
            var ttl = 10f;
            Debug.Log(time);

            if (time >= ttl)
            {
                influenceCounter = manager.GetInfluencePerMin();
                Debug.LogError($"influenceCounter {influenceCounter}");
                time = 0;
            }
        }
    }
}

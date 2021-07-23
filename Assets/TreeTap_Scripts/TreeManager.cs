using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TreeManager : ManagerService, ICurrencySystem
{
    [HideInInspector]
    public int Trees;

    public int BaseIncreaseAmount;
    public int TreeTapModifier;

    public Text treeCountDisplay;

    public Button treePlantButton;

    private UnityAction onTapped;

    private void Awake()
    {
        onTapped += Increase_Count;

        treePlantButton.onClick.AddListener(onTapped);    
    }

    public void Decrease_Count()
    {
        throw new System.NotImplementedException();
    }

    public void Get_Count()
    {
        throw new System.NotImplementedException();
    }

    public void Increase_Count()
    {
        Trees = (Trees + BaseIncreaseAmount) + TreeTapModifier;
        Debug.Log($"{Trees} Trees");

        treeCountDisplay.text = $"{Trees} Tree's Planted";
    }

    public void Set_Count()
    {
        throw new System.NotImplementedException();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapModifierButton : MonoBehaviour
{
    int curModifier = 1;

    public Text buttonText;
    public Text tapUIText;

    public void OnClick_UpgradeModifier()
    {
        curModifier += 1;

        buttonText.text = (curModifier + 1) + "x Tap";
        tapUIText.text = "+ " + curModifier;

        TapModifier.OnChange_TapModifier(curModifier);
    }
}

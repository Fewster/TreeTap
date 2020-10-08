using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TapModifier
{
    public static int tapModifier;

    public static int OnChange_TapModifier(int modifier)
    {
        tapModifier = modifier;
        return modifier;
    }
}

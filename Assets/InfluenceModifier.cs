using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InfluenceModifier
{
    public static float base_influenceModifier = 0.01f;
    public static float modifier = 0;

    public static float influenceModifier;

    public static float OnChange_InfluenceModifier()
    {
        influenceModifier = modifier + base_influenceModifier;
        return influenceModifier;
    }
}

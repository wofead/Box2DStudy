﻿using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GUIColorExample : MonoBehaviour
{
    [GUIColor(0.3f, 0.8f, 0.8f, 1f)]
    public int ColorInt1;

    [GUIColor(0.3f, 0.8f, 0.8f, 1f)]
    public int ColorInt2;

    [ButtonGroup]
    [GUIColor(0,1,0)]
    private void Apply()
    {
        Debug.Log("Apply");
    }
    [ButtonGroup]
    [GUIColor(1, 0.6f, 0.4f)]
    private void Cancel()
    {
        Debug.Log("Cancle");
    }

    [ButtonGroup]
    [GUIColor(0, 0.6f, 0.4f)]
    private void Confirm()
    {
        Debug.Log("Confirm");
    }


    [GUIColor("GetButtonColor")]
    [Button(ButtonSizes.Gigantic)]
    private static void IAmFabulous()
    {
    }

    private static Color GetButtonColor()
    {
        Sirenix.Utilities.Editor.GUIHelper.RequestRepaint();
        return Color.HSVToRGB(Mathf.Cos((float)UnityEditor.EditorApplication.timeSinceStartup + 1f) * 0.225f + 0.325f, 1, 1);
    }

    // [GUIColor("@Color.Lerp(Color.red, Color.green, Mathf.Sin((float)EditorApplication.timeSinceStartup))")]
    // [GUIColor("CustomColor")]
    // 这两个写法相等
    [Button(ButtonSizes.Large)]
    [GUIColor("@Color.Lerp(Color.red, Color.green, Mathf.Sin((float)EditorApplication.timeSinceStartup))")]
    private static void Expressive_One()
    {
    }

    [Button(ButtonSizes.Large)]
    [GUIColor("CustomColor")]
    private static void Expressive_Two()
    {
    }

# if UNITY_EDITOR
    public Color CustomColor()
    {
        return Color.Lerp(Color.red, Color.green, Mathf.Sin((float)EditorApplication.timeSinceStartup));
    }
# endif
}

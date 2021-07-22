using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OdinStaticInspector : MonoBehaviour
{
    public enum TempEnum
    {
        One, Two, Three
    }

    public static TempEnum tempEnum;
    public static string tempStr;
    public static int tempInt;
    public static List<StaticInspectorTurialsOne> staticInspectorTurials = new List<StaticInspectorTurialsOne>();

    [Button(ButtonSizes.Large)]
    [GUIColor(0.1f, 0.5f,0f)]
    public static void TestStaticFunction()
    {
        Debug.Log("TestFunction");
    }

    [Button(ButtonSizes.Large, ButtonStyle.FoldoutButton)]
    [GUIColor(0f, 0.1843f, 0.6549f)]
    public static void TestStaticFunction(string str)
    {
        Debug.Log($"TestFunction:{str}");
    }

    [Button(ButtonSizes.Large, ButtonStyle.FoldoutButton)]
    public static void TestStaticFuction(List<string> tempList)
    {
        for (int i = 0; i < tempList.Count; i++)
        {
            Debug.Log($"List Index : {i} ----- value:{tempList[i]}");
        }
    }

    public void NoStaticFunction()
    {
        Debug.Log("No Static Function");
    }
}

public class StaticInspectorTurialsOne
{
    public static string tempStr;
}
using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DrawWithUnityExample : MonoBehaviour
{
    [InfoBox("如果你曾经遇到过Odin属性的问题，那么很有可能使用DrawWithUnity")]
    public GameObject ObjectDrawnWithOdin;

    [DrawWithUnity]
    public GameObject ObjectDrawnWithUnity;
}

using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HideLabelExample : MonoBehaviour
{
    public string showLabel = "jow";
    [HideLabel]
    public string hideLabel = "hide jow";

    [ShowInInspector]
    public string ShowPropertyLabel { get; set; }

    [HideLabel][ShowInInspector]
    public string HidePropertyLabel { get; set; }

    
}

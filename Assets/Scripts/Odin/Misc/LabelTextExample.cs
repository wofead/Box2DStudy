using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LabelTextExample : MonoBehaviour
{
    [LabelText("1")]
    public int MyInt1;

    [LabelText("2")]
    public int MyInt2;

    [LabelText("3")]
    public int MyInt3;

    [InfoBox("Use $ to refer to a member string.")]
    [LabelText("$DynamicLabel")]
    public string DynamicLabel = "DynamicLabel";

    [InfoBox("Use @ to execute an expression.")]
    [LabelText("@DateTime.Now.ToString(\"HH:mm:ss\")")]
    public string TimeString;
}

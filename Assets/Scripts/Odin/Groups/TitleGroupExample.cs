using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleGroupExample : MonoBehaviour
{
    [TitleGroup("Default")]
    public string DefaultTitleGroup;

    [TitleGroup("Defaultq", "can choose subtitle")]
    public string TitleGroup;

    [TitleGroup("Centered", Alignment = TitleAlignments.Centered)]

    public string Centered;

    [TitleGroup("Left", Alignment = TitleAlignments.Left)]

    public string Left;

    [TitleGroup("Right", Alignment = TitleAlignments.Right)]

    public string Right;

    [TitleGroup("Split", Alignment = TitleAlignments.Split)]

    public string Split;

    [TitleGroup("$DynamicTitle")]
    public string DynamicTitle;

    [TitleGroup("Vectors", "Optional subtitle", alignment: TitleAlignments.Centered, horizontalLine: true, boldTitle: true, indent: true)]
    public Vector2 SomeVector0;
    [TitleGroup("Vectors_Indent", "Optional subtitle", alignment: TitleAlignments.Centered, horizontalLine: true, boldTitle: true, indent: false)]
    public Vector2 SomeVector1;

    [TitleGroup("NoTitle", horizontalLine: false)]
    public string noTitleStr = "noTitleStrContent";
}

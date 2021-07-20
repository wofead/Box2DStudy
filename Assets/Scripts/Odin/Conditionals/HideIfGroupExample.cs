using Sirenix.OdinInspector;
using Sirenix.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideIfGroupExample : MonoBehaviour
{
    public bool Toggle = true;

    [HideIfGroup("Toggle")]
    [BoxGroup("Toggle/Shown Box")]
    public int A, B;

    [BoxGroup("Box")]
    public InfoMessageType EnumField = InfoMessageType.Info;

    [BoxGroup("Box")]
    [HideIfGroup("Box/Toggle")]
    public Vector3 X, Y;

    //与常规if属性一样，HideIfGroup也支持指定值
    //你还可以将多个HideIfGroup属性链接在一起，以实现更复杂的行为。
    [HideIfGroup("Box/Toggle/EnumField", Value = InfoMessageType.Info)]
    [BoxGroup("Box/Toggle/EnumField/Border", ShowLabel = false)]
    public string Name;

    [BoxGroup("Box/Toggle/EnumField/Border")]
    public Vector3 Vector;

    // HideIfGroup将默认使用组的名称
    //但是你也可以使用MemberName属性来覆盖它。
    [HideIfGroup("RectGroup", Condition = "Toggle")]
    public Rect Rect;
}

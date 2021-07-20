using Sirenix.OdinInspector;
using Sirenix.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowIfGroupExample : MonoBehaviour
{
    public bool Toggle = true;

    [ShowIfGroup("Toggle")]
    [BoxGroup("Toggle/Shown Box")]
    public int A, B;

    [BoxGroup("Box")]
    public InfoMessageType EnumField = InfoMessageType.Info;

    [BoxGroup("Box")]
    [ShowIfGroup("Box/Toggle")]
    public Vector3 X, Y;

    //与常规if属性一样，ShowIfGroup也支持指定值
    //你还可以将多个ShowIfGroup属性链接在一起，以实现更复杂的行为。
    [ShowIfGroup("Box/Toggle/EnumField", Value = InfoMessageType.Info)]
    [BoxGroup("Box/Toggle/EnumField/Border", ShowLabel = false)]
    public string Name;

    [BoxGroup("Box/Toggle/EnumField/Border")]
    public Vector3 Vector;

    // ShowIfGrouop将默认使用组的名称
    //但是你也可以使用MemberName属性来覆盖它。
    [ShowIfGroup("RectGroup", Condition = "Toggle")]
    public Rect Rect;
}

using Sirenix.OdinInspector;
using Sirenix.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableIfExample : MonoBehaviour
{
    public UnityEngine.Object SomeObject;

    [EnumToggleButtons]
    public InfoMessageType SomeEnum;

    public bool IsToggled;

    [EnableIf("SomeEnum", InfoMessageType.Info)]
    public Vector2 Info;

    [EnableIf("SomeEnum", InfoMessageType.Error)]
    public Vector2 Error;

    [EnableIf("SomeEnum", InfoMessageType.Warning)]
    public Vector2 Warning;

    [EnableIf("SomeEnum", InfoMessageType.None)]
    public Vector2 None;

    [EnableIf("IsToggled")]
    public int EnableIfToggled;

    [EnableIf("SomeObject")]
    public Vector3 EnaledWhenHasReference;

    [EnableIf("@this.IsToggled && this.SomeObject != null || this.SomeEnum == InfoMessageType.Error")]
    public int EnableWithExpression;
}

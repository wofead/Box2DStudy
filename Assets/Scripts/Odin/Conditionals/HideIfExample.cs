using Sirenix.OdinInspector;
using Sirenix.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideIfExample : MonoBehaviour
{
    public UnityEngine.Object SomeObject;

    [EnumToggleButtons]
    public InfoMessageType SomeEnum;

    public bool IsToggled;

    [HideIf("SomeEnum", InfoMessageType.Info)]
    public Vector2 Info;

    [HideIf("SomeEnum", InfoMessageType.Error)]
    public Vector2 Error;

    [HideIf("SomeEnum", InfoMessageType.Warning)]
    public Vector2 Warning;

    [HideIf("SomeEnum", InfoMessageType.None)]
    public Vector2 None;

    [HideIf("IsToggled")]
    public int HideIfToggled;

    [HideIf("SomeObject")]
    public Vector3 HideWhenHasReference;

    [HideIf("@this.IsToggled && this.SomeObject != null || this.SomeEnum == InfoMessageType.Error")]
    public int HideWithExpression;
}

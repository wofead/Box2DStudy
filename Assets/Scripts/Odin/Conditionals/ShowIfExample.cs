using Sirenix.OdinInspector;
using Sirenix.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowIfExample : MonoBehaviour
{
    public UnityEngine.Object SomeObject;

    [EnumToggleButtons]
    public InfoMessageType SomeEnum;

    public bool IsToggled;

    [DisableIf("SomeEnum", InfoMessageType.Info)]
    public Vector2 Info;

    [DisableIf("SomeEnum", InfoMessageType.Error)]
    public Vector2 Error;

    [DisableIf("SomeEnum", InfoMessageType.Warning)]
    public Vector2 Warning;

    [DisableIf("SomeEnum", InfoMessageType.None)]
    public Vector2 None;

    [DisableIf("IsToggled")]
    public int EnableIfToggled;

    [DisableIf("SomeObject")]
    public Vector3 EnaledWhenHasReference;

    [DisableIf("@this.IsToggled && this.SomeObject != null || this.SomeEnum == InfoMessageType.Error")]
    public int EnableWithExpression;
}

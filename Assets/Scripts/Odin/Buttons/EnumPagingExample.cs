using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumPagingExample : MonoBehaviour
{
    [EnumPaging]
    public SomeEnum SomeEnumField;

    public enum SomeEnum
    {
        A, B, C
    }

    [ShowInInspector]
    [EnumPaging, OnValueChanged("SetCurrentTool")]
    [InfoBox("Changing this property will change the current the currnet selected tool in the Unity editor.")]
    private UnityEditor.Tool sceneTool;

    private void SetCurrentTool()
    {
        UnityEditor.Tools.current = this.sceneTool;
    }
}

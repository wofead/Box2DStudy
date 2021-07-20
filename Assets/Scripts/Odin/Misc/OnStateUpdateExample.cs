using Sirenix.OdinInspector;
using Sirenix.Utilities.Editor;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OnStateUpdateExample : MonoBehaviour
{
    public List<string> list0;

    [OnStateUpdate("@#(list0).State.Expanded = $value")]
    public bool ExpandList;//此bool值通过上述表达式控制list0列表

    [OnStateUpdate("@$property.State.Expanded = ExpandList1")]
    public List<string> list1;
    public bool ExpandList1;

    [OnStateUpdate("@$property.State.Visible = ToggleMyInt")]
    public int MyInt;
    public bool ToggleMyInt;

    [OnStateUpdate("CustomPropertyUpdateCallBack")]
    public string MyString;

    private void CustomPropertyUpdateCallBack(string tempMyString)
    {
        if (!string.IsNullOrEmpty(tempMyString))
        {
            Debug.Log(tempMyString);
        }
    }
}

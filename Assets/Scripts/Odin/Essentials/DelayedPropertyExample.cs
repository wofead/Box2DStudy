using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Sirenix.OdinInspector;

public class DelayedPropertyExample : MonoBehaviour
{
    [OnValueChanged("ValueChangedCallBack")]
    public int field;
    [ShowInInspector]
    [OnValueChanged("ValueChangedCallBack")]
    private string property { get; set; }

    //延迟和延迟属性实际上是相同的
    [Delayed]
    [OnValueChanged("ValueChangedCallBack")]
    public int delayField;
    //但是，正如名称所示，DelayedProperty应用于属性。
    [ShowInInspector, DelayedProperty]
    [OnValueChanged("ValueChangedCallBack")]
    public string delayProperty { get; set; }

    public void ValueChangedCallBack()
    {
        Debug.Log("value changed");
    }
}

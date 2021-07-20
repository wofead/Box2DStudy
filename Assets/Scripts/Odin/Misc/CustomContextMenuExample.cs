using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CustomContextMenuExample : MonoBehaviour
{
    [InfoBox("右键属性可在菜单中发出指定的函数。")]
    [CustomContextMenu("Say Hello/Jow", "SayHelloFunction")]
    public int MyProperty;

    private void SayHelloFunction()
    {
        Debug.Log("Hello Jow");
    }
}

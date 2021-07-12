using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ReadOnlyExample : MonoBehaviour
{
    [ReadOnly]
    public string MyString = "Jow";

    [ReadOnly]
    public int MyInt = 5;

    [ReadOnly]
    public int[] MyIntArr = new int[] { 1, 2, 3, 4, 5, 6, 7 };


}

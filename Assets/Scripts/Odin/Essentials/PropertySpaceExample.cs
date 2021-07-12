using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PropertySpaceExample : MonoBehaviour
{
    [Space]
    public int unitySpace;

    [Space(5)]
    public int unitySpace1;

    [PropertySpace]
    public int OdinSpace;

    [ShowInInspector, PropertySpace]
    public int Property { get; set; }

    //还可以控制Property属性前后的间距。
    [PropertySpace(SpaceBefore = 30, SpaceAfter = 30)]
    public int BeforeAndAfter;

    [PropertySpace(SpaceBefore = 30, SpaceAfter = 30)]
    public int BeforeAndAfter1;


}

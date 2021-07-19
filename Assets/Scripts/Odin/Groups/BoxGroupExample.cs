using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxGroupExample : MonoBehaviour
{
    [BoxGroup("Some Title")]
    public string A;
    [BoxGroup("Some Title")]
    public string B;

    [BoxGroup("Centered Title", centerLabel: true)]
    public string C;
    [BoxGroup("Centered Title")]
    public string D;

    public string DynamicBoxTitle = "DynamicBoxTitle";
    [BoxGroup("$DynamicBoxTitle")]
    public string E = "Dynamic box title 2";
    [BoxGroup("$DynamicBoxTitle")]
    public string F;

    [BoxGroup]
    public string G;
    [BoxGroup]
    public string H;

    [BoxGroup("NoTitle", false)]
    public string I;
    [BoxGroup("NoTitle")]
    public string J;

    [BoxGroup("Layer")]
    public string layer = "";
    [BoxGroup("Layer/One")]
    public string layer_1 = "";
    [BoxGroup("Layer/One/Two")]
    public string layer_2 = "";
    [BoxGroup("Layer/One/Two/Three")]
    public string layer_3 = "";
}

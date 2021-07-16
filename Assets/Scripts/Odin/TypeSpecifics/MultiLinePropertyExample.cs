﻿using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using UnityEngine;

public class MultiLinePropertyExample : MonoBehaviour
{
    [Multiline(10)]
    public string UnityMultiLineField = "";

    [Title("多行文本字段", bold: false)]
    [HideLabel]
    [MultiLineProperty(10)]
    public string WideMultilineTextField = "";

    [InfoBox("Odin支持属性,但是Unity自己的多行属性只适用于字段")]
    [ShowInInspector]
    [MultiLineProperty(10)]
    public string OdinMultilineProperty { get; set; }

}


﻿using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LabelWidthExample : MonoBehaviour
{
    public int DefaultWidth;
    [LabelWidth(50)]
    public int Thin;

    [LabelWidth(300)]
    public int Wide;


}

using Sirenix.OdinInspector;
using Sirenix.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideInPlayMode : MonoBehaviour
{
    [Title("Hidden in play mode")]//在Editor模式下隐藏，运行时显示。
    [HideInPlayMode]
    public int C;

    [HideInPlayMode]
    public int D;
}

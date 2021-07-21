using Sirenix.OdinInspector;
using Sirenix.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableInPlayModeExample : MonoBehaviour
{
    [Title("Disable in play mode")]//在Editor模式下隐藏，运行时显示。
    [DisableInPlayMode]
    public int C;

    [DisableInPlayMode]
    public int D;
}

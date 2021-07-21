using Sirenix.OdinInspector;
using Sirenix.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideInEdittorMode : MonoBehaviour
{
    [Title("Hidden in editor mode")]//在Editor模式下隐藏，运行时显示。
    [HideInEditorMode]
    public int C;

    [HideInEditorMode]
    public int D;
}

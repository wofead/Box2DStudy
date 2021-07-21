using Sirenix.OdinInspector;
using Sirenix.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableInEditorModeExample : MonoBehaviour
{
    [Title("Disable in Editor mode")]//在Editor模式下置灰，运行时可编辑。
    [DisableInEditorMode]
    public int C;

    [DisableInEditorMode]
    public int D;
}

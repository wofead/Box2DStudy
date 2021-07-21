using Sirenix.OdinInspector;
using Sirenix.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInlineEditorsExample : MonoBehaviour
{
    [InfoBox("单击属性值打开一个新的检查窗口，也可以看到这些属性的不同。")]
    [InlineEditor(Expanded = true)]
    public MyInlineScriptableObject InlineObject;
}

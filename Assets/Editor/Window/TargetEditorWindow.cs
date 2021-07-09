using Sirenix.OdinInspector.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TargetEditorWindow : OdinEditorWindow
{
    [MenuItem("Odin/TargetWindow")]
    private static void OpenWindow()
    {
        GetWindow<TargetEditorWindow>().Show();
    }

    protected override void Initialize()
    {
        this.WindowPadding = Vector4.zero;
    }

    protected override object GetTarget()
    {
        return Selection.activeObject;
    }
}

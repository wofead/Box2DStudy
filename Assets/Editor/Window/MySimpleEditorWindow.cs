using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/*
 * 通过从OdinEditorWindow而不是EditorWindow继承，您可以使Unity编辑器窗口的方式与创建检查器的方式完全相同：仅使用属性。

提示：您可以使用 OnInspectorGUI 属性，如果您希望将自定义编辑器IMGUI代码与Odin绘制的编辑器混合使用
 */
public class MySimpleEditorWindow : OdinEditorWindow
{
    [MenuItem("Odin/OdinWindow")]
    private static void OpenWindow()
    {
        GetWindow<MySimpleEditorWindow>().Show();
    }

    public string Hello = "Little Bird Jow";

    [EnumToggleButtons, BoxGroup("Settings")]
    public ScaleMode ScaleMode;

    [FolderPath(RequireExistingPath = true), BoxGroup("Settings")]
    public string OutputPath;

    [HorizontalGroup(0.5f)]//占比0.5
    public List<Texture> InputTextures;

    [HorizontalGroup, InlineEditor(InlineEditorModes.LargePreview)]
    public Texture Preview;

    [Button(ButtonSizes.Gigantic), GUIColor(0, 1, 0)]
    public void PerformSomeAction()
    {

    }
}

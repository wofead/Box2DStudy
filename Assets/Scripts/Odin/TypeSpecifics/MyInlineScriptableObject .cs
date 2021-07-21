using Sirenix.OdinInspector;
using UnityEngine;
[CreateAssetMenu(fileName = "MyInlineScriptableObject_ScriptableObject", menuName = "CreatScriptableObject/MyInlineScriptableObject", order = 100)]
public class MyInlineScriptableObject : ScriptableObject
{
    [ShowInInlineEditors]
    public string ShownInInlineEditor;

    [HideInInlineEditors]//在绘制的里面不显示
    public string HiddenInlineEditor;

    [DisableInInlineEditors]//显示但是是灰态
    public string DisabledInInlineEditor;
}

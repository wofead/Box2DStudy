using Sirenix.OdinInspector;
using UnityEngine;
[CreateAssetMenu(fileName = "MyScripty_ScriptableObject", menuName = "CreatScriptableObject/MyScripty", order = 100)]
[TypeInfoBox("TypeInfoBox 特性 能以文本的形式显示在顶端。例如，MonoBehaviors or ScriptableObjects.")]
public class MyScripty : ScriptableObject
{
    public string MyText = "MyText";
    [TextArea(10, 15)]
    public string box;
}

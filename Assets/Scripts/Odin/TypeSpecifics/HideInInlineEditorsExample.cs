using Sirenix.OdinInspector;
using UnityEngine;

public class HideInInlineEditorsExample : MonoBehaviour
{
    [InfoBox("Clike the pen icon to open a new inspector window for the InlineObject to see the diffences these attributes make.")]
    [InlineEditor(Expanded = true)]
    public MyInlineScriptableObject InlineObject;

    public void Start()
    {
        InlineObject = ScriptableObject.CreateInstance<MyInlineScriptableObject>();
    }
}

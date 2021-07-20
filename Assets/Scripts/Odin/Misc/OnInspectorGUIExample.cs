using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OnInspectorGUIExample : MonoBehaviour
{
    [OnInspectorGUI("DrawPreview", append: true)]
    public Texture2D Texture;

    private void DrawPreview()
    {
        if (this.Texture ==null)
        {
            return;
        }

        GUILayout.BeginVertical(GUI.skin.box);
        GUILayout.Label(this.Texture);
        GUILayout.EndVertical();
    }

    [OnInspectorGUI]
    private void OnInspectorGUI()
    {
        UnityEditor.EditorGUILayout.HelpBox("OnInspectorGUI还可以用于方法和属性", UnityEditor.MessageType.Error);
    }
}

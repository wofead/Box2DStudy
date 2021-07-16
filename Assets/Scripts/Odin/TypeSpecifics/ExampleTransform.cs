using Sirenix.OdinInspector;
using UnityEngine;
[CreateAssetMenu(fileName = "ExampleTransform_ScriptableObject", menuName = "CreatScriptableObject/ExampleTransform", order = 100)]
public class ExampleTransform : ScriptableObject
{
    public Vector3 Position;
    public Vector3 Rotation;
    public Vector3 Scale;
}

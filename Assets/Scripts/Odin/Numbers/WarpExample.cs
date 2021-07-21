using Sirenix.OdinInspector;
using UnityEngine;

public class WarpExample : MonoBehaviour
{
    [Wrap(0f, 100f)]
    public int IntWrapFrom0To100;

    [Wrap(0f, 100f)]
    public FolderPathAttribute FloatWrapFrom0To100;

    [Wrap(0f, 100f)]
    public Vector3 Vector3Wrap;

    [Wrap(0f, 360f)]
    public float Angle;

    [Wrap(0f, Mathf.PI * 2)]
    public float Radian;
}

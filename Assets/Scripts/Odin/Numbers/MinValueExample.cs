using Sirenix.OdinInspector;
using UnityEngine;

public class MinValueExample : MonoBehaviour
{
    [MinValue(0)]
    public int MinInt;

    [MinValue(0)]
    public float MinFloat;

    [MinValue(0)]
    public Vector3 MinVec3;
}

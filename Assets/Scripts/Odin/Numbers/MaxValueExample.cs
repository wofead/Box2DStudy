using Sirenix.OdinInspector;
using UnityEngine;

public class MaxValueExample : MonoBehaviour
{
    [MaxValue(0)]
    public int MaxInt;

    [MaxValue(0)]
    public float MaxFloat;

    [MaxValue(0)]
    public Vector3 MaxVec3;
}

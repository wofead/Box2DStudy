using Sirenix.OdinInspector;
using UnityEngine;

public class RangeExample : MonoBehaviour
{
    [Range(0, 10)]
    public int Range = 5;

    [InfoBox("Odin的PropertyRange属性类类似于Unity的Range属性，但也适用于属性。")]
    [ShowInInspector, PropertyRange(0, 10)]
    public int Property { get; set; }

    [InfoBox("你还可以为最小值和最大值中的一个或两个引用成员。")]
    [PropertyRange(0, "Max"), PropertyOrder(3)]
    public int Dynamic = 6;

    [PropertyOrder(4)]
    public int Max = 100;
}

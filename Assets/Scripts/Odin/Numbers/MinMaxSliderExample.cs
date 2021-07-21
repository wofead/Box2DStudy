using Sirenix.OdinInspector;
using UnityEngine;

public class MinMaxSliderExample : MonoBehaviour
{
    [MinMaxSlider(-10, 10)]
    public Vector2 MinMaxSlider = new Vector2(-7, -2);

    [MinMaxSlider(-10, 10, true)]
    public Vector2 WithFileds = new Vector2(-3, 4);

    [InfoBox("你还可以通过引用成员来动态分配最大值最小值。")]
    [MinMaxSlider("DynamicRange", true)]
    public Vector2 DynamicMinmMax = new Vector2(25, 50);

    [MinMaxSlider("Min", 10f, true)]
    public Vector2 DynamicMin = new Vector2(2, 7);

    [InfoBox("你还可以使用带用@符号的属性表达式")]
    [MinMaxSlider("@DynamicRange.x", "@DynamicRange.y * 10f", true)]
    public Vector2 Expressive = new Vector2(0, 450);

    public Vector2 DynamicRange = new Vector2(0, 50);

    public float Min { get { return this.DynamicRange.x; } }
    public float Max { get { return this.DynamicRange.y; } }
}

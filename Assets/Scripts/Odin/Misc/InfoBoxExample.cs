using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InfoBoxExample : MonoBehaviour
{
    [Title("InfoBox message Types")]
    [InfoBox("Default InfoBox")]
    public int A;

    [InfoBox("Warning InfoBox", InfoMessageType = InfoMessageType.Warning)]
    public int B;

    [InfoBox("Error InfoBox", InfoMessageType = InfoMessageType.Error)]
    public int C;

    [InfoBox("None InfoBox", InfoMessageType = InfoMessageType.None)]
    public int D;

    [Title("有条件的信息框")]
    public bool ToggleInfoBoxes;

    [InfoBox("This info box is only shown while in editor mode.", InfoMessageType.Error, "isInEditMode")]
    public float G;

    private static bool IsInEditMode()
    {
        return !Application.isPlaying;
    }

    [InfoBox("可以由静态字段隐藏", "ToggleInfoBoxes")]
    public int E;
    [InfoBox("可以由静态字段隐藏", "ToggleInfoBoxes")]
    public int F;

    [InfoBox("$InfoBoxMessage")]
    [InfoBox("@\"Time: \" + DateTime.Now.ToString(\"HH:mm:ss\")")]
    public string InfoBoxMessage = "My dynamic info box message";

}

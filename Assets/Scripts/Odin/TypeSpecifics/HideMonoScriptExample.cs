using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(fileName = "HideMonoScriptExample_ScriptableObject", menuName = "CreatScriptableObject/HideMonoScriptExample")]
[HideMonoScript]
public class HideMonoScriptExample : ScriptableObject
{
    public string Value;

}

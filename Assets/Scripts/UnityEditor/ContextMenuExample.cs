using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContextMenuExample : MonoBehaviour
{
    [ContextMenu("DoSometing")]
    private void DoSometing()
    {
        Debug.Log("Do Someting");
    }

    [Button(ButtonSizes.Medium)]
    private void ButtonClick()
    {
        Debug.Log("Click");
    }

    
}

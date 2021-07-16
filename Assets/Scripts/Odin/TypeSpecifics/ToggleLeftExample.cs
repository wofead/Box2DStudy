using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLeftExample : MonoBehaviour
{

    [ToggleLeft]
    public bool LeftToggled;

    public bool normalBool;
}

using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleExample : MonoBehaviour
{

    [Toggle("Enabled")]
    public MyToggleable Toggler = new MyToggleable();

    public ToggleableClass Toggleable = new ToggleableClass();

    [Serializable]
    public class MyToggleable
    {
        public bool Enabled;
        public int MyvValue;
    }

    [Serializable, Toggle("Enabled")]
    public class ToggleableClass
    {
        public bool Enabled;
        public string Text;
    }
}

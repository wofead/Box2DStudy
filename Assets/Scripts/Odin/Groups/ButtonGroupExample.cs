using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGroupExample : MonoBehaviour
{
    [ButtonGroup]
    public void A()
    {

    }

    [ButtonGroup]
    public void B()
    {

    }

    [ButtonGroup]
    public void C()
    {

    }

    [ButtonGroup]
    public void D()
    {

    }

    [Button(ButtonSizes.Large)]
    [ButtonGroup("My Button Group")]
    private void E()
    {
    }
    [GUIColor(0, 1, 0)]
    [ButtonGroup("My Button Group")]
    private void F()
    {
    }

    [BoxGroup("Titles", ShowLabel = false)]
    public int A1;
    [BoxGroup("Titles/Boxed")]
    public int B1;
    public int C1;
    [ButtonGroup("Titles/Buttons")]
    public void FirstButton() { }
    [ButtonGroup("Titles/Buttons")]
    public void SecondButton() { }
}

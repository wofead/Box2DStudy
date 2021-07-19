using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InlineButtomExample : MonoBehaviour
{
    [InlineButton("A")]
    public int InlineButton;

    [InlineButton("A")]
    [InlineButton("B", "Custom Button Name")]
    public int ChaineButtons;

    private void A()
    {
        Debug.Log("A");
    }

    private void B()
    {
        Debug.Log("B");
    }
}

using UnityEngine;

public class DelayedExample : MonoBehaviour
{
    [DelayedAttribute()]
    public string content;
    [Multiline(10)]
    public string MultiLineStr;

    [TextArea()]
    public string TextAreaStr;
}

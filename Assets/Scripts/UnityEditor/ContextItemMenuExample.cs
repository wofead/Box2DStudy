using UnityEngine;

public class ContextItemMenuExample : MonoBehaviour
{
    [ContextMenuItem("Reset", "ResetString")]
    public string Name = "  ";
    private void ResetString()
    {
        Debug.Log("Do Someting");
    }

    
}
